using ApiNet8.Data;
using ApiNet8.Models;
using ApiNet8.Models.Club;
using ApiNet8.Models.DTO;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using ApiNet8.Utils;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace ApiNet8.Services
{
    public class ConfiguracionServices : IConfiguracionServices
    {
        private readonly ApplicationDbContext _db;
        private string secretToken;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ConfiguracionServices(ApplicationDbContext db, IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this._db = db;
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public Perfil ActualizarPerfil(PerfilDTO perfil, List<int> permisosNuevos)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");
                Perfil per = GetPerfilById(perfil.Id);

                using (var transaction = _db.Database.BeginTransaction())
                {
                    per.NombrePerfil = perfil.NombrePerfil ?? per.NombrePerfil;
                    per.DescripcionPerfil = perfil.DescripcionPerfil ?? per.DescripcionPerfil;
                    per.FechaModificacion = DateTime.Now;
                    per.UsuarioEditor = currentUser.Id;
                    _db.Update(per);
                    _db.SaveChanges();
                    transaction.Commit();
                }

                List<Permiso> permisosViejos = GetPermisosByPerfil(perfil);

                // Comparar y actualizar permisos
                foreach (var nuevoPermiso in permisosNuevos)
                {
                    Permiso permisoExistente = null;
                    if (permisosViejos != null)
                    {
                        permisoExistente = permisosViejos.FirstOrDefault(p => p.Id == nuevoPermiso);
                    }

                    if (permisoExistente == null)
                    {
                        Permiso permisoAsoc = _db.Permiso.Where(p => p.Id == nuevoPermiso).FirstOrDefault();
                        PerfilPermiso perfilPermiso = new PerfilPermiso
                        {
                            Perfil = per,
                            Permiso = permisoAsoc,
                            FechaCreacion = DateTime.Now,
                            UsuarioEditor = currentUser.Id
                        };
                        _db.Add(perfilPermiso);
                    }
                }
                if (permisosViejos != null)
                {
                    foreach (var permisoActual in permisosViejos)
                    {
                        bool permisoEnNuevaLista = permisosNuevos.Contains(permisoActual.Id);
                        if (!permisoEnNuevaLista)
                        {
                            // Permiso ya no está en la nueva lista, establecer FechaBaja
                            PerfilPermiso perfilPermiso = _db.PerfilPermiso.Include(pp => pp.Permiso).Include(pp => pp.Perfil).FirstOrDefault(pp => pp.Permiso.Id == permisoActual.Id && pp.Perfil.Id == per.Id && pp.FechaBaja == null);
                            if (perfilPermiso != null)
                            {
                                perfilPermiso.FechaBaja = DateTime.Now;
                                _db.Update(perfilPermiso);
                            }
                        }
                    }
                }
                // Guardar cambios en la base de datos
                _db.SaveChanges();


                return per;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
        }

        public Perfil CrearPerfil(PerfilDTO perfil, List<int> permisos)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Perfil per = _mapper.Map<Perfil>(perfil);
                per.UsuarioEditor = currentUser.Id;
                per.FechaCreacion = DateTime.Now;
                _db.Add(per);
                _db.SaveChanges();

                using (var transaction = _db.Database.BeginTransaction())
                {
                    Perfil perfilNuevo = _db.Perfil.Where(p => p.NombrePerfil == per.NombrePerfil).FirstOrDefault();
                    foreach (int perm in permisos)
                    {
                        Permiso permisoAsoc = _db.Permiso.Where(p => p.Id == perm).FirstOrDefault();
                        PerfilPermiso perfilPermiso = new PerfilPermiso();
                        perfilPermiso.Perfil = perfilNuevo;
                        perfilPermiso.Permiso = permisoAsoc;
                        perfilPermiso.FechaCreacion = DateTime.Now;
                        perfilPermiso.UsuarioEditor = currentUser.Id;
                        _db.Add(perfilPermiso);
                        _db.SaveChanges();

                    }
                    transaction.Commit();
                }

                return per;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public bool ExistePerfilClub(PerfilClubDTO perfilClubDTO)
        {
            var perfilClub = _db.PerfilClub.FirstOrDefault(u => u.NombrePerfilClub == perfilClubDTO.NombrePerfilClub);
            if (perfilClub == null)
            {
                return false;
            }
            return true;
        }

        public PerfilClub CrearPerfilClub(PerfilClubDTO perfilClubDTO)
        {
            try
            {
                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                var existePerfilClub = ExistePerfilClub(perfilClubDTO);
                if (existePerfilClub)
                {
                    throw new Exception("Ya existe un perfil con ese nombre");
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    PerfilClub perfilClubActivo = _db.PerfilClub.Where(p => p.Activo == true).FirstOrDefault();

                    if (perfilClubActivo!=null)
                    {
                        perfilClubActivo.Activo = false;
                        _db.Update(perfilClubActivo);
                    }

                    PerfilClub perfilClub = new PerfilClub
                    {
                        NombrePerfilClub = perfilClubDTO.NombrePerfilClub,
                        UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                        FechaCreacion = DateTime.Now,
                        Activo = true,
                    };

                    ClubHistorial clubHistorial = new ClubHistorial
                    {
                        FechaCreacion = DateTime.Now,
                    };

                    ParametrosClub parametrosClub = new ParametrosClub
                    {
                        Nombre = perfilClubDTO.NombrePerfilClub,
                        ColorPrincipal = perfilClubDTO.ColorPrincipal,
                        ColorSecundario = perfilClubDTO.ColorSecundario,
                        LogoPequenio = perfilClubDTO.LogoPequenio ?? null,
                        LogoGrande = perfilClubDTO.LogoGrande ?? null,
                        IconoPlataforma = perfilClubDTO.IconoPlataforma ?? null,
                        TextoBannerEmail = perfilClubDTO.TextoBannerEmail,
                        TextoFooterEmail = perfilClubDTO.TextoFooterEmail,
                        ColorBannerEmail = perfilClubDTO.ColorBannerEmail,
                        TextoEmail = perfilClubDTO.TextoEmail,
                        TituloQuienesSomos = perfilClubDTO.TituloQuienesSomos,
                        DescripcionQuienesSomos = perfilClubDTO.DescripcionQuienesSomos,
                        PerfilClub = perfilClub,
                        clubHistoriales = new List<ClubHistorial>()
                    };

                    parametrosClub.clubHistoriales.Add(clubHistorial);

                    _db.Add(perfilClub);
                    _db.Add(clubHistorial);
                    _db.Add(parametrosClub);
                    _db.SaveChanges();
                    transaction.Commit();

                    return perfilClub;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message,e);
            }
        }

        public PerfilClub GetPerfilClubById (int id)
        {
            try
            {
                return _db.PerfilClub.Find(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message,e);
            }
        }

        public PerfilClub ActualizarPerfilClub(PerfilClubDTO perfilClubDTO)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                // obtener perfilclub, parametrosclub y club historial
                PerfilClub perfilClub = GetPerfilClubById(perfilClubDTO.Id);

                if (perfilClub == null) {
                    throw new Exception("No existe el perfil");
                }

                ParametrosClub parametrosClub = _db.ParametrosClub.Include(pp => pp.clubHistoriales).Where(p=> p.PerfilClub.Id==perfilClubDTO.Id).FirstOrDefault();
                ClubHistorial clubHistorial = parametrosClub.clubHistoriales.Where(c=> c.FechaBaja == null).FirstOrDefault();

                if (parametrosClub == null || clubHistorial == null) {
                    throw new Exception("No existe un parametro o un historial asociado a ese perfil");
                }

                // actualizar clases
                using (var transaction = _db.Database.BeginTransaction())
                {
                    perfilClub.NombrePerfilClub = perfilClubDTO.NombrePerfilClub;
                    perfilClub.FechaModificacion = DateTime.Now;
                    perfilClub.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                    parametrosClub.Nombre = perfilClubDTO.NombrePerfilClub ?? perfilClub.NombrePerfilClub;
                    parametrosClub.ColorPrincipal = perfilClubDTO.ColorPrincipal ?? parametrosClub.ColorPrincipal;
                    parametrosClub.ColorSecundario = perfilClubDTO.ColorSecundario ?? parametrosClub.ColorSecundario;
                    parametrosClub.LogoPequenio = perfilClubDTO.LogoPequenio ?? parametrosClub.LogoPequenio;
                    parametrosClub.LogoGrande = perfilClubDTO.LogoGrande ?? parametrosClub.LogoGrande;
                    parametrosClub.IconoPlataforma = perfilClubDTO.IconoPlataforma ?? parametrosClub.IconoPlataforma;
                    parametrosClub.TextoBannerEmail = perfilClubDTO.TextoBannerEmail ?? parametrosClub.TextoBannerEmail;
                    parametrosClub.TextoFooterEmail = perfilClubDTO.TextoFooterEmail ?? parametrosClub.TextoFooterEmail;
                    parametrosClub.ColorBannerEmail = perfilClubDTO.ColorBannerEmail ?? parametrosClub.ColorBannerEmail;
                    parametrosClub.TextoEmail = perfilClubDTO.TextoEmail ?? parametrosClub.TextoEmail;
                    parametrosClub.TituloQuienesSomos = perfilClubDTO.TituloQuienesSomos ?? parametrosClub.TituloQuienesSomos;
                    parametrosClub.DescripcionQuienesSomos = perfilClubDTO.DescripcionQuienesSomos ?? parametrosClub.DescripcionQuienesSomos;

                    clubHistorial.FechaBaja = DateTime.Now;
                    clubHistorial.UsuarioEditor = currentUser != null ? currentUser.Id : 0;

                    ClubHistorial clubHistorialNuevo = new ClubHistorial()
                    {
                        FechaCreacion = DateTime.Now,
                        UsuarioEditor = 1
                    };

                    parametrosClub.clubHistoriales.Add(clubHistorialNuevo);

                    _db.Add(clubHistorialNuevo);
                    _db.Update(perfilClub);
                    _db.Update(parametrosClub);
                    _db.Update(clubHistorial);
                    _db.SaveChanges();
                    transaction.Commit();

                    return perfilClub;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void EliminarPerfilClub(int id)
        {
            try
            {
                PerfilClub perfilClub = GetPerfilClubById(id);
                ParametrosClub parametrosClub = _db.ParametrosClub.Include(pp => pp.clubHistoriales).Where(p => p.PerfilClub.Id == id).FirstOrDefault();
                ClubHistorial clubHistorial = parametrosClub.clubHistoriales.Where(c => c.FechaBaja == null).FirstOrDefault();

                if (parametrosClub == null || clubHistorial == null)
                {
                    throw new Exception("No existe un parametro o un historial asociado a ese perfil");
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    perfilClub.FechaBaja = DateTime.Now;
                    perfilClub.Activo = false;
                    clubHistorial.FechaBaja = DateTime.Now;
                    _db.Update(perfilClub);
                    _db.Update(clubHistorial);
                    _db.SaveChanges();
                    transaction.Commit();                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PerfilClubResponseDTO GetPerfilClubActivo()
        {
            try
            {
                PerfilClub perfilClub = _db.PerfilClub.Where(p => p.Activo == true).FirstOrDefault();
                ParametrosClub parametrosClub = _db.ParametrosClub.Where(p=>p.PerfilClub.Id == perfilClub.Id).FirstOrDefault();

                if (perfilClub==null || parametrosClub==null)
                {
                    throw new Exception("No existe un perfil activo ó no tiene parámetros.");
                }

                PerfilClubResponseDTO response = new PerfilClubResponseDTO 
                {
                    NombrePerfilClub = perfilClub.NombrePerfilClub,
                    UsuarioEditor = perfilClub.UsuarioEditor,
                    ColorPrincipal = parametrosClub.ColorPrincipal,
                    ColorSecundario = parametrosClub.ColorSecundario,
                    LogoPequenio = parametrosClub.LogoPequenio,
                    LogoGrande = parametrosClub.LogoGrande,
                    IconoPlataforma = parametrosClub.IconoPlataforma,
                    TextoBannerEmail = parametrosClub.TextoBannerEmail,
                    TextoFooterEmail = parametrosClub.TextoFooterEmail,
                    ColorBannerEmail = parametrosClub.ColorBannerEmail,
                    TextoEmail = parametrosClub.TextoEmail,
                    TituloQuienesSomos = parametrosClub.TituloQuienesSomos,
                    DescripcionQuienesSomos = parametrosClub.DescripcionQuienesSomos                     
                };

                return response;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public PerfilClubQuienesSomosDTO GetPerfilClubQuienesSomos()
        {
            try
            {
                PerfilClubResponseDTO perfilActivo = GetPerfilClubActivo();

                PerfilClubQuienesSomosDTO response = new PerfilClubQuienesSomosDTO
                {
                    TituloQuienesSomos = perfilActivo.TituloQuienesSomos,
                    DescripcionQuienesSomos = perfilActivo.DescripcionQuienesSomos
                };

                return response;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Perfil EliminarPerfil(int id)
        {
            try
            {
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                Perfil per = this.GetPerfilById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    per.FechaBaja = DateTime.Now;
                    per.UsuarioEditor = currentUser.Id;
                    _db.Update(per);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return per;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message,e);
            }

        }

        public bool ExistePerfil(string nombre)
        {
            var perfil = _db.Perfil.FirstOrDefault(p => p.NombrePerfil == nombre);
            if (perfil == null)
            {
                return false;
            }
            return true;
        }

        public PerfilResponseDTO GetPerfilYPermisosById(int Id)
        {
            try
            {
                // obtengo perfil
                Perfil perfil = _db.Perfil.Find(Id);

                // busco permisos del perfil
                PerfilDTO perfilDTO = new PerfilDTO { Id = perfil.Id };
                List<Permiso> permisos = GetPermisosByPerfil(perfilDTO);

                PerfilResponseDTO responseDTO = new PerfilResponseDTO { Perfil = perfil, Permisos = permisos};

                return responseDTO;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Perfil GetPerfilById(int Id)
        {
            try
            {
                return _db.Perfil.Find(Id);  
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public Perfil GetPerfilByNombre(string nombre)
        {
            try
            {
                Perfil perfil = _db.Perfil.Where(p=>p.NombrePerfil == nombre).FirstOrDefault();

                return perfil;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public List<PerfilResponseDTO> GetPerfiles()
        {
            try
            {
                List<Perfil> perfiles = _db.Perfil.Where(p => p.FechaBaja == null).ToList();

                List<PerfilResponseDTO> responseDTO = new List<PerfilResponseDTO>();

                foreach (var perfil in perfiles)
                {
                    // busco los permisos de cada perfil
                    PerfilDTO perfilDTO = new PerfilDTO {Id = perfil.Id };
                    List<Permiso> permisos = GetPermisosByPerfil(perfilDTO);

                    PerfilResponseDTO perfilResponseDTO = new PerfilResponseDTO { Perfil = perfil, Permisos = permisos };
                    responseDTO.Add(perfilResponseDTO);
                }

                return responseDTO;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public List<Permiso> GetPermisos()
        {
            try
            {
                return _db.Permiso.Where(p => p.FechaBaja == null).ToList();// podriamos devolverlos ordenados por id
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        public PerfilUsuario GetPerfilUsuario (Usuario usuario)
        {
            try
            {
                return _db.PerfilUsuario.Include(p => p.Perfil).Include(u => u.Usuario).Where(pu => pu.FechaBaja == null && pu.Usuario.Id == usuario.Id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }
        }

        public List<Permiso> GetPermisosByPerfil(PerfilDTO perfil)
        {
            try
            {
                List<PerfilPermiso> perfilPermisos = _db.PerfilPermiso.Include(pp => pp.Perfil).Include(pp => pp.Permiso).Where(pp => pp.Perfil.Id == perfil.Id && pp.FechaBaja==null).DefaultIfEmpty().ToList();
                
                if (perfilPermisos.FirstOrDefault() == null)
                {
                    return null;
                }
                List<Permiso> permisos = new List<Permiso>();

                foreach (PerfilPermiso perm in perfilPermisos) {
                    permisos.Add(_db.Permiso.Where(p => p.Id == perm.Permiso.Id).FirstOrDefault()); 
                }
                return permisos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public bool ExisteTYC(TerminosYCondicionesDTO tyc)
        {
            var existeTYC = _db.TerminosYCondiciones.FirstOrDefault(u => u.TYC == tyc.TYC);
            if (existeTYC == null)
            {
                return false;
            }
            return true;
        }

        public TerminosYCondiciones CrearTYC(TerminosYCondicionesDTO tyc)
        {
            try
            {
                TerminosYCondiciones terminosYCondiciones = _mapper.Map<TerminosYCondiciones>(tyc);

                var existeTYC = ExisteTYC(tyc);

                if (existeTYC)
                {
                    throw new Exception("Ya existen unos términos y condiciones con esa descripción");
                }

                // Obtener el usuario actual desde la sesión
                var currentUser = _httpContextAccessor?.HttpContext?.Session.GetObjectFromJson<CurrentUser>("CurrentUser");

                HistorialTerminosYCondiciones tycHistorial = null;
                // verificar si ya existen otros tyc
                if (_db.HistorialTerminosYCondiciones.Count() > 0 && _db.HistorialTerminosYCondiciones.Any(h=>h.FechaBaja == null))
                {
                    tycHistorial = _db.HistorialTerminosYCondiciones.Where(c => c.FechaBaja == null).FirstOrDefault();
                }
               

                using (var transaction = _db.Database.BeginTransaction())
                {

                    if (tycHistorial != null)
                    {
                        tycHistorial.FechaBaja = DateTime.Now;
                        tycHistorial.FechaFinVigencia = DateTime.Now;
                        _db.Update(tycHistorial);
                    }

                    HistorialTerminosYCondiciones historialTerminosYCondiciones = new HistorialTerminosYCondiciones
                    {
                        FechaCreacion = DateTime.Now,
                        UsuarioEditor = currentUser != null ? currentUser.Id : 0,
                        FechaInicioVigencia = DateTime.Now,
                    };

                    terminosYCondiciones.HistorialTerminosYCondiciones = historialTerminosYCondiciones;

                    _db.Add(historialTerminosYCondiciones);
                    _db.Add(terminosYCondiciones);
                    _db.SaveChanges();
                    transaction.Commit();                    
                }

                return terminosYCondiciones;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
           
        }

        public TerminosYCondiciones ObtenerTYC()
        {
            try
            {
                return _db.TerminosYCondiciones
                .Include(h => h.HistorialTerminosYCondiciones)
                .Where(t => t.HistorialTerminosYCondiciones.FechaBaja == null)
                .FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception("No existen términos y condiciones", e);
            }
            
        }
    }
}
