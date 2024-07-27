﻿using ApiNet8.Data;
using ApiNet8.Models.Club;
using ApiNet8.Models.DTO;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;
using ApiNet8.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;
using XAct;
using XAct.Library.Settings;
using XAct.Users;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiNet8.Services
{
    public class ConfiguracionServices : IConfiguracionServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ConfiguracionServices(ApplicationDbContext db, IMapper mapper)
        {
            this._db = db;
            _mapper = mapper;
        }
        Perfil IConfiguracionServices.ActualizarPerfil(PerfilDTO perfil)
        {
            try
            {
                Perfil per;
                using (var transaction = _db.Database.BeginTransaction())
                {
                    per = ((IConfiguracionServices)this).GetPerfilById(perfil.Id);
                    per.NombrePerfil = perfil.NombrePerfil;
                    per.DescripcionPerfil = perfil.DescripcionPerfil;
                    per.FechaModificacion = DateTime.Now;
                    per.UsuarioEditor = perfil.UsuarioEditor;//Implementar CurrentUser
                    _db.Update(per);
                    _db.SaveChanges();
                    transaction.Commit();
                }
                return per;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e);
            }
        }        

        Perfil IConfiguracionServices.CrearPerfil(Perfil perfil)
        {
            try
            {
                _db.Add(perfil);              
                _db.SaveChanges();
                return perfil;
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

        PerfilClub IConfiguracionServices.CrearPerfilClub(PerfilClubDTO perfilClubDTO)
        {
            try
            {
                var existePerfilClub = ExistePerfilClub(perfilClubDTO);
                if (existePerfilClub)
                {
                    throw new Exception("Ya existe un perfil con ese nombre");
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    PerfilClub perfilClub = new PerfilClub
                    {
                        NombrePerfilClub = perfilClubDTO.NombrePerfilClub,
                        UsuarioEditor = 1,// traer de current user o jwt
                        FechaCreacion = DateTime.Now,
                    };

                    ClubHistorial clubHistorial = new ClubHistorial
                    {
                        FechaCreacion = DateTime.Now,
                    };

                    ParametrosClub parametrosClub = new ParametrosClub
                    {
                        Nombre = perfilClubDTO.Nombre,
                        ColorPrincipal = perfilClubDTO.ColorPrincipal,
                        ColorSecundario = perfilClubDTO.ColorSecundario,
                        LogoPequenio = perfilClubDTO.LogoPequenio ?? null,
                        LogoGrande = perfilClubDTO.LogoGrande ?? null,
                        IconoPlataforma = perfilClubDTO.IconoPlataforma ?? null,
                        TextoBannerEmail = perfilClubDTO.TextoBannerEmail,
                        TextoFooterEmail = perfilClubDTO.TextoFooterEmail,
                        ColorBannerEmail = perfilClubDTO.ColorBannerEmail,
                        TextoEmail = perfilClubDTO.TextoEmail,
                        QuienesSomos = perfilClubDTO.QuienesSomos,
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

        PerfilClub IConfiguracionServices.ActualizarPerfilClub(PerfilClubDTO perfilClubDTO)
        {
            try
            {
               // obtener perfilclub, parametrosclub y club historial
               PerfilClub perfilClub = GetPerfilClubById(perfilClubDTO.Id);

                if (perfilClub == null) {
                    throw new Exception("No existe el perfil");
                }

                ParametrosClub parametrosClub = _db.ParametrosClub.Where(p=> p.PerfilClub.Id==perfilClubDTO.Id).FirstOrDefault();
                ClubHistorial clubHistorial = parametrosClub.clubHistoriales.Where(c=> c.FechaBaja == null).FirstOrDefault();

                if (parametrosClub == null || clubHistorial == null) {
                    throw new Exception("No existe un parametro o un historial asociado a ese perfil");
                }

                // actualizar clases
                using (var transaction = _db.Database.BeginTransaction())
                {
                    perfilClub.NombrePerfilClub = perfilClubDTO.NombrePerfilClub;
                    perfilClub.FechaModificacion = DateTime.Now;
                    perfilClub.UsuarioEditor = 1;// usar current user o jwt

                    parametrosClub.Nombre = perfilClubDTO.Nombre;
                    parametrosClub.ColorPrincipal = perfilClubDTO.ColorPrincipal;
                    parametrosClub.ColorSecundario = perfilClubDTO.ColorSecundario;
                    parametrosClub.LogoPequenio = perfilClubDTO.LogoPequenio;
                    parametrosClub.LogoGrande = perfilClubDTO.LogoGrande;
                    parametrosClub.IconoPlataforma = perfilClubDTO.IconoPlataforma;
                    parametrosClub.TextoBannerEmail = perfilClubDTO.TextoBannerEmail;
                    parametrosClub.TextoFooterEmail = perfilClubDTO.TextoFooterEmail;
                    parametrosClub.ColorBannerEmail = perfilClubDTO.ColorBannerEmail;
                    parametrosClub.TextoEmail = perfilClubDTO.TextoEmail;
                    parametrosClub.QuienesSomos = perfilClubDTO.QuienesSomos;

                    clubHistorial.FechaBaja = DateTime.Now;
                    clubHistorial.UsuarioEditor = 1;// usar current user o jwt

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

        PerfilClub IConfiguracionServices.EliminarPerfilClub(int id)
        {
            try
            {
                PerfilClub perfilClub = GetPerfilClubById(id);
                ParametrosClub parametrosClub = _db.ParametrosClub.Where(p => p.PerfilClub.Id == id).FirstOrDefault();
                ClubHistorial clubHistorial = parametrosClub.clubHistoriales.Where(c => c.FechaBaja == null).FirstOrDefault();

                if (parametrosClub == null || clubHistorial == null)
                {
                    throw new Exception("No existe un parametro o un historial asociado a ese perfil");
                }

                using (var transaction = _db.Database.BeginTransaction())
                {
                    perfilClub.FechaBaja = DateTime.Now;                 
                    clubHistorial.FechaBaja = DateTime.Now;
                    _db.Update(perfilClub);
                    _db.Update(clubHistorial);
                    _db.SaveChanges();
                    transaction.Commit();
                    return perfilClub;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        Perfil IConfiguracionServices.EliminarPerfil(int id)
        {
            try
            {
                Perfil per = ((IConfiguracionServices)this).GetPerfilById(id);
                using (var transaction = _db.Database.BeginTransaction())
                {
                    per.FechaBaja = DateTime.Now;
                    //per.UsuarioEditor = Current.User.Id;
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

        bool IConfiguracionServices.ExistePerfil(string nombre)
        {
            var perfil = _db.Perfil.FirstOrDefault(p => p.NombrePerfil == nombre);
            if (perfil == null)
            {
                return false;
            }
            return true;
        }

        Perfil IConfiguracionServices.GetPerfilById(int Id)
        {
            try
            {
                // en el filter action ya verificamos que el id es valido y que el perfil existe, la unica validacion que hacemos aca es por si rompe el llamado a la base
                Perfil perfil = _db.Perfil.Find(Id);

                return perfil;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        List<Perfil> IConfiguracionServices.GetPerfiles()
        {
            try
            {
                return _db.Perfil.ToList();// podriamos devolverlos ordenados por id
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }

        }

        List<Permiso> IConfiguracionServices.GetPermisosByPerfil(Perfil perfil)
        {
            try
            {
                List<PerfilPermiso> perfilPermisos = _db.PerfilPermiso.Include(pp => pp.Perfil).Include(pp => pp.Permiso).Where(pp => pp.Perfil.Id == perfil.Id).DefaultIfEmpty().ToList();
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

            throw new NotImplementedException();
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

                HistorialTerminosYCondiciones tycHistorial = _db.HistorialTerminosYCondiciones.Where(c => c.FechaBaja == null).FirstOrDefault();

                using (var transaction = _db.Database.BeginTransaction())
                {

                    if (tycHistorial != null)
                    {
                        tycHistorial.FechaBaja = DateTime.Now;
                        _db.Update(tycHistorial);
                    }

                    HistorialTerminosYCondiciones historialTerminosYCondiciones = new HistorialTerminosYCondiciones
                    {
                        FechaCreacion = DateTime.Now,
                        UsuarioEditor = 0
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
    }
}
