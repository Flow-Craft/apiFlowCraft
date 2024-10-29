using ApiNet8.Data;
using ApiNet8.Services.IServices;
using AutoMapper;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Layout.Properties;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models.Eventos;
using iText.Layout.Borders;
using ApiNet8.Models.Reservas;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.DTO;
using ApiNet8.Models.Partidos;
using ApiNet8.Utils;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using SkiaSharp;
using Svg.Skia;


namespace ApiNet8.Services
{
    public class ReporteServices : IReporteServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEventoServices _eventoServices;
        private readonly IUsuarioServices _usuarioServices;
        private readonly ITipoEventoServices _tipoEventoServices;
        private readonly IInstalacionServices _instalacionServices;
        private readonly IDisciplinasYLeccionesServices _disciplinasYLeccionesServices;
        private readonly IEquipoServices _equipoServices;
        private readonly IPartidoServices _partidoServices;
        private readonly ITipoAccionPartidoServices _tipoAccionPartidoServices;
        private readonly ILeccionesServices _leccionesServices;


        public ReporteServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IEventoServices eventoServices, IUsuarioServices usuarioServices, ITipoEventoServices tipoEventoServices, IInstalacionServices instalacionServices, IDisciplinasYLeccionesServices disciplinasYLeccionesServices, IEquipoServices equipoServices, IPartidoServices partidoServices, ITipoAccionPartidoServices tipoAccionPartidoServices, ILeccionesServices leccionesServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _eventoServices = eventoServices;
            _usuarioServices = usuarioServices;
            _tipoEventoServices = tipoEventoServices;
            _instalacionServices = instalacionServices;
            _disciplinasYLeccionesServices = disciplinasYLeccionesServices;
            _equipoServices = equipoServices;
            _partidoServices = partidoServices;
            _tipoAccionPartidoServices = tipoAccionPartidoServices;
            _leccionesServices = leccionesServices;
        }

        public byte[] ReporteEventoUsuarioPeriodo(DateTime periodoInicio, DateTime periodoFin, int idUsuario)
        {
            // Crear el PDF en memoria
            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Obtén el directorio raíz de la aplicación
                var rootPath = Directory.GetCurrentDirectory();

                // Construye la ruta a la carpeta "Images" dentro del proyecto
                var imagePath = Path.Combine(rootPath, "Images", "LogoReporte.jpeg");

                // Agregar logo
                Image logo = new Image(ImageDataFactory.Create(imagePath));
                logo.ScaleToFit(50, 50); // Cambia el tamaño a 50x50 puntos
                document.Add(logo);

                // Título
                Paragraph title = new Paragraph("Asistencia a eventos por usuario y periodo")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // Fecha de generación y periodo
                DateTime fechaGeneracion = DateTime.Now;
                document.Add(new Paragraph($"Fecha de generación: {fechaGeneracion}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Periodo: {periodoInicio.ToShortDateString()} a {periodoFin.ToShortDateString()}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12));

                // Datos del usuario
                Usuario? usuario = _usuarioServices.GetUsuarioById(idUsuario);
                if (usuario == null)
                {
                    throw new Exception("No existe el usuario");
                }
                document.Add(new Paragraph($"Nombre y apellido Usuario: {usuario.Nombre} {usuario.Apellido}")
                    .SetFontSize(12));
                document.Add(new Paragraph($"DNI Usuario: {usuario.Dni}")
                    .SetFontSize(12));

                // Tabla de eventos
                Table table = new Table(new float[] { 4, 4, 4, 4 });
                table.SetWidth(UnitValue.CreatePercentValue(100));

                table.AddHeaderCell(new Cell().Add(new Paragraph("Evento")).SetBorderBottom(new SolidBorder(1)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Instalación")).SetBorderBottom(new SolidBorder(1)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Fecha")).SetBorderBottom(new SolidBorder(1)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Tipo de Evento")).SetBorderBottom(new SolidBorder(1)));

                // traer asistencias por usuario en rango fechas
                List<Asistencia> asistenciasUsuario = _eventoServices.GetAsistenciasByUsuarioAndPeriodo(idUsuario, periodoInicio, periodoFin);

                foreach (var evento in asistenciasUsuario)
                {
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.Titulo)).SetBorderBottom(new SolidBorder(1)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.Instalacion.Nombre)).SetBorderBottom(new SolidBorder(1)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.FechaInicio?.ToShortDateString() ?? string.Empty)).SetBorderBottom(new SolidBorder(1)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.TipoEvento.NombreTipoEvento)).SetBorderBottom(new SolidBorder(1)));
                }

                document.Add(table);

                // Cantidad de eventos
                document.Add(new Paragraph($"Cantidad total de eventos: {asistenciasUsuario.Count}")
                    .SetFontSize(12));

                // Cerrar el documento
                document.Close();

                // Retornar el PDF generado como un byte[]
                return memoryStream.ToArray();
            }
        }

        public byte[] ReporteEventoTipoEventoPeriodo(DateTime periodoInicio, DateTime periodoFin, int idTipoEvento)
        {
            // Crear el PDF en memoria
            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Obtén el directorio raíz de la aplicación
                var rootPath = Directory.GetCurrentDirectory();

                // Construye la ruta a la carpeta "Images" dentro del proyecto
                var imagePath = Path.Combine(rootPath, "Images", "LogoReporte.jpeg");

                // Agregar logo
                Image logo = new Image(ImageDataFactory.Create(imagePath));
                logo.ScaleToFit(50, 50); // Cambia el tamaño a 50x50 puntos
                document.Add(logo);

                // Título
                Paragraph title = new Paragraph("Asistencia a eventos por tipo de evento y periodo")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // Fecha de generación y periodo
                DateTime fechaGeneracion = DateTime.Now;
                document.Add(new Paragraph($"Fecha de generación: {fechaGeneracion}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Periodo: {periodoInicio.ToShortDateString()} a {periodoFin.ToShortDateString()}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12));

                // Datos del usuario
                TipoEvento? tipoEvento = _tipoEventoServices.GetTipoEventoById(idTipoEvento);
                if (tipoEvento == null)
                {
                    throw new Exception("No existe el tipo de evento");
                }
                document.Add(new Paragraph($"Tipo de evento: {tipoEvento.NombreTipoEvento}")
                    .SetFontSize(12));


                // Tabla de eventos
                Table table = new Table(new float[] { 4, 4, 4, 4, 6 });
                table.SetWidth(UnitValue.CreatePercentValue(100));

                table.AddHeaderCell(new Cell().Add(new Paragraph("Evento")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Instalación")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Fecha")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Dni")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre y apellido")));


                // traer asistencias por tipo evento en rango fechas
                List<Asistencia> asistenciasUsuario = _eventoServices.GetAsistenciasByTipoEventoAndPeriodo(idTipoEvento, periodoInicio, periodoFin);

                foreach (var evento in asistenciasUsuario)
                {
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.Titulo)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.Instalacion.Nombre)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.FechaInicio?.ToShortDateString() ?? string.Empty)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Usuario.Dni.ToString())));
                    table.AddCell(new Cell().Add(new Paragraph($"{evento.Usuario.Nombre}  {evento.Usuario.Apellido}")));
                }

                document.Add(table);

                // Contar la cantidad de eventos distintos en la lista de asistencias
                int cantidadEventosDistintos = asistenciasUsuario
                    .Select(a => a.Evento.Id)
                    .Distinct()
                    .Count();

                // Cantidad de eventos
                document.Add(new Paragraph($"Cantidad total de eventos: {cantidadEventosDistintos}")
                    .SetFontSize(12));

                // Cantidad de asistencias
                document.Add(new Paragraph($"Cantidad total de asistencias: {asistenciasUsuario.Count}")
                    .SetFontSize(12));

                // Cerrar el documento
                document.Close();

                // Retornar el PDF generado como un byte[]
                return memoryStream.ToArray();
            }
        }

        public byte[] ReporteEventoInstalacionPeriodo(DateTime periodoInicio, DateTime periodoFin, int idInstalacion)
        {
            // Crear el PDF en memoria
            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Obtén el directorio raíz de la aplicación
                var rootPath = Directory.GetCurrentDirectory();

                // Construye la ruta a la carpeta "Images" dentro del proyecto
                var imagePath = Path.Combine(rootPath, "Images", "LogoReporte.jpeg");

                // Agregar logo
                Image logo = new Image(ImageDataFactory.Create(imagePath));
                logo.ScaleToFit(50, 50); // Cambia el tamaño a 50x50 puntos
                document.Add(logo);

                // Título
                Paragraph title = new Paragraph("Asistencia a eventos por instalacion y periodo")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // Fecha de generación y periodo
                DateTime fechaGeneracion = DateTime.Now;
                document.Add(new Paragraph($"Fecha de generación: {fechaGeneracion}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Periodo: {periodoInicio.ToShortDateString()} a {periodoFin.ToShortDateString()}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12));

                // Datos del usuario
                Instalacion? instalacion = _instalacionServices.GetInstalacionById(idInstalacion);
                if (instalacion == null)
                {
                    throw new Exception("No existe la instalacion");
                }
                document.Add(new Paragraph($"Instalacion: {instalacion.Nombre}")
                    .SetFontSize(12));


                // Tabla de eventos
                Table table = new Table(new float[] { 4, 4, 4, 4, 6 });
                table.SetWidth(UnitValue.CreatePercentValue(100));

                table.AddHeaderCell(new Cell().Add(new Paragraph("Evento")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Fecha")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Dni")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre y apellido")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Tipo de Evento")));

                // traer asistencias por instalacion en rango fechas
                List<Asistencia> asistenciasUsuario = _eventoServices.GetAsistenciasByInstalacionAndPeriodo(idInstalacion, periodoInicio, periodoFin);

                foreach (var evento in asistenciasUsuario)
                {
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.Titulo)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.FechaInicio?.ToShortDateString() ?? string.Empty)));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Usuario.Dni.ToString())));
                    table.AddCell(new Cell().Add(new Paragraph($"{evento.Usuario.Nombre}  {evento.Usuario.Apellido}")));
                    table.AddCell(new Cell().Add(new Paragraph(evento.Evento.TipoEvento.NombreTipoEvento)));
                }

                document.Add(table);

                // Contar la cantidad de eventos distintos en la lista de asistencias
                int cantidadEventosDistintos = asistenciasUsuario
                    .Select(a => a.Evento.Id)
                    .Distinct()
                    .Count();

                // Cantidad de eventos
                document.Add(new Paragraph($"Cantidad total de eventos: {cantidadEventosDistintos}")
                    .SetFontSize(12));

                // Cantidad de asistencias
                document.Add(new Paragraph($"Cantidad total de asistencias: {asistenciasUsuario.Count}")
                    .SetFontSize(12));

                // Cerrar el documento
                document.Close();

                // Retornar el PDF generado como un byte[]
                return memoryStream.ToArray();
            }
        }

        public byte[] ReporteEventoByEvento(int idEvento)
        {
            // Crear el PDF en memoria
            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Obtén el directorio raíz de la aplicación
                var rootPath = Directory.GetCurrentDirectory();

                // Construye la ruta a la carpeta "Images" dentro del proyecto
                var imagePath = Path.Combine(rootPath, "Images", "LogoReporte.jpeg");

                // Agregar logo
                Image logo = new Image(ImageDataFactory.Create(imagePath));
                logo.ScaleToFit(50, 50); // Cambia el tamaño a 50x50 puntos
                document.Add(logo);

                // Título
                Paragraph title = new Paragraph("Asistencia a eventos por evento")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // obtener evento
                Evento evento = _eventoServices.GetEventoById(idEvento);

                // Fecha de generación 
                DateTime fechaGeneracion = DateTime.Now;
                document.Add(new Paragraph($"Fecha de generación: {fechaGeneracion}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12));

                // fecha de evento
                document.Add(new Paragraph($"Fecha de evento: {evento.FechaInicio}")
                    .SetFontSize(12));

                // tipo de evento
                document.Add(new Paragraph($"Tipo de evento: {evento.TipoEvento.NombreTipoEvento}")
                    .SetFontSize(12));

                // Datos del usuario
                Instalacion? instalacion = _instalacionServices.GetInstalacionById(evento.Instalacion.Id);
                if (instalacion == null)
                {
                    throw new Exception("No existe la instalacion");
                }
                document.Add(new Paragraph($"Instalacion: {instalacion.Nombre}")
                    .SetFontSize(12));


                // Tabla de eventos
                Table table = new Table(new float[] { 4, 6 });
                table.SetWidth(UnitValue.CreatePercentValue(100));

                table.AddHeaderCell(new Cell().Add(new Paragraph("Dni")));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre y apellido")));

                // traer asistencias por evento
                List<Asistencia> asistenciasUsuario = _eventoServices.GetAsistenciasByEvento(idEvento);

                foreach (var asistencia in asistenciasUsuario)
                {
                    table.AddCell(new Cell().Add(new Paragraph(asistencia.Usuario.Dni.ToString())));
                    table.AddCell(new Cell().Add(new Paragraph($"{asistencia.Usuario.Nombre}  {asistencia.Usuario.Apellido}")));
                }

                document.Add(table);


                // Cantidad de asistencias
                document.Add(new Paragraph($"Cantidad total de asistencias: {asistenciasUsuario.Count}")
                    .SetFontSize(12));

                // Cerrar el documento
                document.Close();

                // Retornar el PDF generado como un byte[]
                return memoryStream.ToArray();
            }
        }

        public byte[] ReporteEstadisticaDiscUsuPeriodo(DateTime periodoInicio, DateTime periodoFin, int idDisciplina, int idUsuario)
        {

            // Crear el PDF en memoria
            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Obtén el directorio raíz de la aplicación
                var rootPath = Directory.GetCurrentDirectory();

                // Construye la ruta a la carpeta "Images" dentro del proyecto
                var imagePath = Path.Combine(rootPath, "Images", "LogoReporte.jpeg");

                // Agregar logo
                Image logo = new Image(ImageDataFactory.Create(imagePath));
                logo.ScaleToFit(50, 50); // Cambia el tamaño a 50x50 puntos
                document.Add(logo);

                // Título
                Paragraph title = new Paragraph("Estadísticas por disciplina, usuario y periodo")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // Fecha de generación y periodo
                DateTime fechaGeneracion = DateTime.Now;
                document.Add(new Paragraph($"Fecha de generación: {fechaGeneracion}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Periodo: {periodoInicio.ToShortDateString()} a {periodoFin.ToShortDateString()}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12));

                // disciplina
                Disciplina? disciplina = _disciplinasYLeccionesServices.GetDisciplinaById(idDisciplina);
                if (disciplina == null)
                {
                    throw new Exception("No existe la disciplina seleccionada");
                }
                document.Add(new Paragraph($"Disciplina: {disciplina.Nombre}")
                   .SetFontSize(12));

                // Datos del usuario
                Usuario? usuario = _usuarioServices.GetUsuarioById(idUsuario);
                if (usuario == null)
                {
                    throw new Exception("No existe el usuario");
                }
                document.Add(new Paragraph($"Nombre y apellido Usuario: {usuario.Nombre} {usuario.Apellido}")
                    .SetFontSize(12));
                document.Add(new Paragraph($"Fecha de nacimiento: {usuario.FechaNacimiento}")
                    .SetFontSize(12));

                // puesto jugador
                List<string> posicionesJugador = _equipoServices.GetPuestosJugador(idUsuario);
                string puestos = string.Join(", ", posicionesJugador);

                // voley
                if (disciplina.Nombre == Enums.Disciplinas.Voleyball.ToString())
                {
                    // Tabla de estadisticas
                    Table table = new Table(new float[] { 4, 4, 2, 4, 2, 4, 2, 4 });
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Acciones")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("+")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje +")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("/")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje /")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("-")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje -")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Total")).SetBorderBottom(new SolidBorder(1)));

                    // traer estadisticas por usuario en rango fechas de la disciplina
                    EstadisticaDTO estadisticasDTO = new EstadisticaDTO
                    {
                        Leccion = false,
                        IdDisciplina = idDisciplina,
                        FechaDesde = periodoInicio,
                        FechaHasta = periodoFin,
                        DNIUsuario = usuario.Dni
                    };
                    List<Estadisticas> estadisticas = _partidoServices.GetEstadisticasByDiscUsuPer(estadisticasDTO);
                    List<ReporteEstadisticaDTO> tablaEstadisticas = new List<ReporteEstadisticaDTO>();

                    // Obtener las estadísticas agrupadas por el nombre del tipo de acción
                    var estadisticasAgrupadas = estadisticas
                        .GroupBy(e => e.TipoAccionPartido?.NombreTipoAccion)
                        .Where(grupo => grupo.Key != null); // Ignorar acciones sin tipo

                    foreach (var grupo in estadisticasAgrupadas)
                    {
                        var tipoAccion = grupo.Key;

                        // Filtrar por el tipo de acción actual y contar cada marca
                        int totalBien = grupo.Where(e => e.MarcaEstadistica == "+").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "+").FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int totalRegular = grupo.Where(e => e.MarcaEstadistica == "/").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "/").FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int totalMal = grupo.Where(e => e.MarcaEstadistica == "-").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "-").FirstOrDefault()!.PuntajeTipoAccion : 0;

                        int total = totalBien + totalRegular + totalMal;

                        // Calcular porcentajes
                        int porcentajeBien = total > 0 ? (totalBien * 100) / total : 0;
                        int porcentajeRegular = total > 0 ? (totalRegular * 100) / total : 0;
                        int porcentajeMal = total > 0 ? (totalMal * 100) / total : 0;

                        // Crear un nuevo ReporteEstadisticaDTO y asignar valores
                        ReporteEstadisticaDTO reporte = new ReporteEstadisticaDTO
                        {
                            Accion = tipoAccion!,
                            Bien = totalBien,
                            PorcentajeBien = porcentajeBien,
                            Regular = totalRegular,
                            PorcentajeRegular = porcentajeRegular,
                            Mal = totalMal,
                            PorcentajeMal = porcentajeMal,
                            Total = total
                        };

                        // Añadir el reporte a la lista final
                        tablaEstadisticas.Add(reporte);
                    }

                    foreach (var est in tablaEstadisticas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(est.Accion)).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Bien.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeBien.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Regular.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeRegular.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Mal.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeMal.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Total.ToString())).SetBorderBottom(new SolidBorder(1)));
                    }
                    document.Add(table);

                    // Uso de la imagen convertida en tu PDF
                    byte[] graficoBytes = GenerarGraficoEstadisticasVoley(tablaEstadisticas);
                    ImageData graficoImageData = ImageDataFactory.Create(graficoBytes);
                    Image graficoImage = new Image(graficoImageData);
                    // Ajustar tamaño del gráfico y añadir separación del contenido anterior
                    graficoImage.ScaleToFit(400, 300);
                    graficoImage.SetMarginTop(40); // Espacio superior de 20 unidades
                    document.Add(graficoImage);
                }

                if (disciplina.Nombre == Enums.Disciplinas.Futbol.ToString())
                {
                    // Tabla de estadisticas
                    Table table = new Table(new float[] { 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Partido")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Pases correctos")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Goles")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates afuera")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates a puerta")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Asistencias")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Amarillas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Rojas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Faltas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates atajados")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Goles recibidos")).SetBorderBottom(new SolidBorder(1)));

                    // traer estadisticas por usuario en rango fechas de la disciplina
                    EstadisticaDTO estadisticasDTO = new EstadisticaDTO
                    {
                        Leccion = false,
                        IdDisciplina = idDisciplina,
                        FechaDesde = periodoInicio,
                        FechaHasta = periodoFin,
                        DNIUsuario = usuario.Dni
                    };
                    List<Estadisticas> estadisticas = _partidoServices.GetEstadisticasByDiscUsuPer(estadisticasDTO);
                    List<ReporteEstadisticaDTO> tablaEstadisticas = new List<ReporteEstadisticaDTO>();

                    // Obtener las estadísticas agrupadas por partido
                    var estadisticasAgrupadas = estadisticas
                        .GroupBy(e => e.Partido?.Titulo)
                        .Where(grupo => grupo.Key != null); // Ignorar acciones sin tipo

                    int totalPasesCorrectos = 0;
                    int totalGoles = 0;
                    int totalRematesFuera = 0;
                    int totalRematesAPuerta = 0;
                    int totalAsistencias = 0;
                    int totalAmarillas = 0;
                    int totalRojas = 0;
                    int totalFaltas = 0;
                    int totalRematesAtajados = 0;
                    int totalGolesRecibidos = 0;

                    foreach (var grupo in estadisticasAgrupadas)
                    {
                        var partido = grupo.Key;

                        int pasesCorrectos = grupo.Where(e => e?.TipoAccionPartido?.Id == 6).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 6).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int goles = grupo.Where(e => e?.TipoAccionPartido?.Id == 1).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 1).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesFuera = grupo.Where(e => e?.TipoAccionPartido?.Id == 9).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 9).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesAPuerta = grupo.Where(e => e?.TipoAccionPartido?.Id == 8).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 8).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int asistencias = grupo.Where(e => e?.TipoAccionPartido?.Id == 7).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 7).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int amarillas = grupo.Where(e => e?.TipoAccionPartido?.Id == 3).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 3).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rojas = grupo.Where(e => e?.TipoAccionPartido?.Id == 4).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 4).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int faltas = grupo.Where(e => e?.TipoAccionPartido?.Id == 2).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 2).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesAtajados = grupo.Where(e => e?.TipoAccionPartido?.Id == 11).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 11).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int golesRecibidos = grupo.Where(e => e?.TipoAccionPartido?.Id == 12).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 12).FirstOrDefault()!.PuntajeTipoAccion : 0;

                        // actualizar totales
                        totalPasesCorrectos += pasesCorrectos;
                        totalGoles += goles;
                        totalRematesFuera += rematesFuera;
                        totalRematesAPuerta += rematesAPuerta;
                        totalAsistencias += asistencias;
                        totalAmarillas += amarillas;
                        totalRojas += rojas;
                        totalFaltas += faltas;
                        totalRematesAtajados += rematesAtajados;
                        totalGolesRecibidos += golesRecibidos;

                        // Crear un nuevo ReporteEstadisticaDTO y asignar valores
                        ReporteEstadisticaDTO reporte = new ReporteEstadisticaDTO
                        {
                            Partido = partido,
                            PasesCorrectos = pasesCorrectos,
                            Goles = goles,
                            RematesAPuerta = rematesAPuerta,
                            RematesAfuera = rematesFuera,
                            Asistencias = asistencias,
                            Amarillas = amarillas,
                            Rojas = rojas,
                            RematesAtajados = rematesAtajados,
                            GolesRecibidos = golesRecibidos,
                            Faltas = faltas
                        };

                        tablaEstadisticas.Add(reporte);
                        // Añadir el reporte a la lista final
                    }

                    // creo otra fila con los totales
                    ReporteEstadisticaDTO reporteTotales = new ReporteEstadisticaDTO
                    {
                        Partido = "Total",
                        PasesCorrectos = totalPasesCorrectos,
                        Goles = totalGoles,
                        RematesAPuerta = totalRematesAPuerta,
                        RematesAfuera = totalRematesFuera,
                        Asistencias = totalAsistencias,
                        Amarillas = totalAmarillas,
                        Rojas = totalRojas,
                        RematesAtajados = totalRematesAtajados,
                        GolesRecibidos = totalGolesRecibidos,
                        Faltas = totalFaltas
                    };
                    tablaEstadisticas.Add(reporteTotales);

                    foreach (var est in tablaEstadisticas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(est.Partido)).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PasesCorrectos.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Goles.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAfuera.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAPuerta.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Asistencias.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Amarillas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Rojas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Faltas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAtajados.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.GolesRecibidos.ToString())).SetBorderBottom(new SolidBorder(1)));
                    }
                    document.Add(table);

                    // Uso de la imagen convertida en tu PDF
                    byte[] graficoBytes = GenerarGraficoEstadisticasFutbol(tablaEstadisticas);
                    ImageData graficoImageData = ImageDataFactory.Create(graficoBytes);
                    Image graficoImage = new Image(graficoImageData);
                    // Ajustar tamaño del gráfico y añadir separación del contenido anterior
                    graficoImage.ScaleToFit(400, 300);
                    graficoImage.SetMarginTop(40); // Espacio superior de 20 unidades
                    document.Add(graficoImage);
                }

                // Cerrar el documento
                document.Close();

                // Retornar el PDF generado como un byte[]
                return memoryStream.ToArray();
            }
        }

        public byte[] ReporteEstadisticaDiscUsuLeccionPeriodo(DateTime periodoInicio, DateTime periodoFin, int idDisciplina, int idLeccion, int idUsuario)
        {
            // Crear el PDF en memoria
            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Obtén el directorio raíz de la aplicación
                var rootPath = Directory.GetCurrentDirectory();

                // Construye la ruta a la carpeta "Images" dentro del proyecto
                var imagePath = Path.Combine(rootPath, "Images", "LogoReporte.jpeg");

                // Agregar logo
                Image logo = new Image(ImageDataFactory.Create(imagePath));
                logo.ScaleToFit(50, 50); // Cambia el tamaño a 50x50 puntos
                document.Add(logo);

                // Título
                Paragraph title = new Paragraph("Estadísticas por disciplina, usuario, leccion y periodo")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // Fecha de generación y periodo
                DateTime fechaGeneracion = DateTime.Now;
                document.Add(new Paragraph($"Fecha de generación: {fechaGeneracion}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Periodo: {periodoInicio.ToShortDateString()} a {periodoFin.ToShortDateString()}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12));

                // leccion
                Leccion leccion = _leccionesServices.GetLeccionById(idLeccion);

                if (leccion == null)
                {
                    throw new Exception("No existe la leccion seleccionada");
                }

                document.Add(new Paragraph($"Leccion: {leccion.Nombre}")
                   .SetFontSize(12));

                // disciplina
                Disciplina? disciplina = _disciplinasYLeccionesServices.GetDisciplinaById(idDisciplina);
                if (disciplina == null)
                {
                    throw new Exception("No existe la disciplina seleccionada");
                }
                document.Add(new Paragraph($"Disciplina: {disciplina.Nombre}")
                   .SetFontSize(12));

                // Datos del usuario
                Usuario? usuario = _usuarioServices.GetUsuarioById(idUsuario);
                if (usuario == null)
                {
                    throw new Exception("No existe el usuario");
                }
                document.Add(new Paragraph($"Nombre y apellido Usuario: {usuario.Nombre} {usuario.Apellido}")
                    .SetFontSize(12));
                document.Add(new Paragraph($"Fecha de nacimiento: {usuario.FechaNacimiento}")
                    .SetFontSize(12));

                // puesto jugador
                List<string> posicionesJugador = _equipoServices.GetPuestosJugador(idUsuario);
                string puestos = string.Join(", ", posicionesJugador);

                // voley
                if (disciplina.Nombre == Enums.Disciplinas.Voleyball.ToString())
                {
                    // Tabla de estadisticas
                    Table table = new Table(new float[] { 4, 4, 2, 4, 2, 4, 2, 4 });
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Acciones")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("+")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje +")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("/")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje /")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("-")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje -")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Total")).SetBorderBottom(new SolidBorder(1)));

                    // traer estadisticas por usuario en rango fechas de la disciplina
                    EstadisticaDTO estadisticasDTO = new EstadisticaDTO
                    {
                        Leccion = true,
                        IdDisciplina = idDisciplina,
                        FechaDesde = periodoInicio,
                        FechaHasta = periodoFin,
                        DNIUsuario = usuario.Dni,
                        IdLeccion = idLeccion,
                    };
                    List<Estadisticas> estadisticas = _partidoServices.GetEstadisticasByDiscUsuPer(estadisticasDTO);
                    List<ReporteEstadisticaDTO> tablaEstadisticas = new List<ReporteEstadisticaDTO>();

                    // Obtener las estadísticas agrupadas por el nombre del tipo de acción
                    var estadisticasAgrupadas = estadisticas
                        .GroupBy(e => e.TipoAccionPartido?.NombreTipoAccion)
                        .Where(grupo => grupo.Key != null); // Ignorar acciones sin tipo

                    foreach (var grupo in estadisticasAgrupadas)
                    {
                        var tipoAccion = grupo.Key;

                        // Filtrar por el tipo de acción actual y contar cada marca
                        int totalBien = grupo.Where(e => e.MarcaEstadistica == "+").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "+").FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int totalRegular = grupo.Where(e => e.MarcaEstadistica == "/").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "/").FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int totalMal = grupo.Where(e => e.MarcaEstadistica == "-").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "-").FirstOrDefault()!.PuntajeTipoAccion : 0;

                        int total = totalBien + totalRegular + totalMal;

                        // Calcular porcentajes
                        int porcentajeBien = total > 0 ? (totalBien * 100) / total : 0;
                        int porcentajeRegular = total > 0 ? (totalRegular * 100) / total : 0;
                        int porcentajeMal = total > 0 ? (totalMal * 100) / total : 0;

                        // Crear un nuevo ReporteEstadisticaDTO y asignar valores
                        ReporteEstadisticaDTO reporte = new ReporteEstadisticaDTO
                        {
                            Accion = tipoAccion!,
                            Bien = totalBien,
                            PorcentajeBien = porcentajeBien,
                            Regular = totalRegular,
                            PorcentajeRegular = porcentajeRegular,
                            Mal = totalMal,
                            PorcentajeMal = porcentajeMal,
                            Total = total
                        };

                        // Añadir el reporte a la lista final
                        tablaEstadisticas.Add(reporte);
                    }

                    foreach (var est in tablaEstadisticas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(est.Accion)).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Bien.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeBien.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Regular.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeRegular.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Mal.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeMal.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Total.ToString())).SetBorderBottom(new SolidBorder(1)));
                    }
                    document.Add(table);

                    // Uso de la imagen convertida en tu PDF
                    byte[] graficoBytes = GenerarGraficoEstadisticasVoley(tablaEstadisticas);
                    ImageData graficoImageData = ImageDataFactory.Create(graficoBytes);
                    Image graficoImage = new Image(graficoImageData);
                    // Ajustar tamaño del gráfico y añadir separación del contenido anterior
                    graficoImage.ScaleToFit(400, 300);
                    graficoImage.SetMarginTop(40); // Espacio superior de 20 unidades
                    document.Add(graficoImage);
                }

                if (disciplina.Nombre == Enums.Disciplinas.Futbol.ToString())
                {
                    // Tabla de estadisticas
                    Table table = new Table(new float[] { 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Partido")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Pases correctos")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Goles")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates afuera")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates a puerta")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Asistencias")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Amarillas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Rojas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Faltas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates atajados")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Goles recibidos")).SetBorderBottom(new SolidBorder(1)));

                    // traer estadisticas por usuario en rango fechas de la disciplina
                    EstadisticaDTO estadisticasDTO = new EstadisticaDTO
                    {
                        Leccion = true,
                        IdDisciplina = idDisciplina,
                        FechaDesde = periodoInicio,
                        FechaHasta = periodoFin,
                        DNIUsuario = usuario.Dni
                    };
                    List<Estadisticas> estadisticas = _partidoServices.GetEstadisticasByDiscUsuPer(estadisticasDTO);
                    List<ReporteEstadisticaDTO> tablaEstadisticas = new List<ReporteEstadisticaDTO>();

                    // Obtener las estadísticas agrupadas por partido
                    var estadisticasAgrupadas = estadisticas
                        .GroupBy(e => e.Partido?.Titulo)
                        .Where(grupo => grupo.Key != null); // Ignorar acciones sin tipo

                    int totalPasesCorrectos = 0;
                    int totalGoles = 0;
                    int totalRematesFuera = 0;
                    int totalRematesAPuerta = 0;
                    int totalAsistencias = 0;
                    int totalAmarillas = 0;
                    int totalRojas = 0;
                    int totalFaltas = 0;
                    int totalRematesAtajados = 0;
                    int totalGolesRecibidos = 0;

                    foreach (var grupo in estadisticasAgrupadas)
                    {
                        var partido = grupo.Key;

                        int pasesCorrectos = grupo.Where(e => e?.TipoAccionPartido?.Id == 6).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 6).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int goles = grupo.Where(e => e?.TipoAccionPartido?.Id == 1).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 1).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesFuera = grupo.Where(e => e?.TipoAccionPartido?.Id == 9).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 9).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesAPuerta = grupo.Where(e => e?.TipoAccionPartido?.Id == 8).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 8).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int asistencias = grupo.Where(e => e?.TipoAccionPartido?.Id == 7).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 7).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int amarillas = grupo.Where(e => e?.TipoAccionPartido?.Id == 3).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 3).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rojas = grupo.Where(e => e?.TipoAccionPartido?.Id == 4).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 4).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int faltas = grupo.Where(e => e?.TipoAccionPartido?.Id == 2).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 2).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesAtajados = grupo.Where(e => e?.TipoAccionPartido?.Id == 11).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 11).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int golesRecibidos = grupo.Where(e => e?.TipoAccionPartido?.Id == 12).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 12).FirstOrDefault()!.PuntajeTipoAccion : 0;

                        // actualizar totales
                        totalPasesCorrectos += pasesCorrectos;
                        totalGoles += goles;
                        totalRematesFuera += rematesFuera;
                        totalRematesAPuerta += rematesAPuerta;
                        totalAsistencias += asistencias;
                        totalAmarillas += amarillas;
                        totalRojas += rojas;
                        totalFaltas += faltas;
                        totalRematesAtajados += rematesAtajados;
                        totalGolesRecibidos += golesRecibidos;

                        // Crear un nuevo ReporteEstadisticaDTO y asignar valores
                        ReporteEstadisticaDTO reporte = new ReporteEstadisticaDTO
                        {
                            Partido = partido,
                            PasesCorrectos = pasesCorrectos,
                            Goles = goles,
                            RematesAPuerta = rematesAPuerta,
                            RematesAfuera = rematesFuera,
                            Asistencias = asistencias,
                            Amarillas = amarillas,
                            Rojas = rojas,
                            RematesAtajados = rematesAtajados,
                            GolesRecibidos = golesRecibidos,
                            Faltas = faltas
                        };

                        tablaEstadisticas.Add(reporte);
                        // Añadir el reporte a la lista final
                    }

                    // creo otra fila con los totales
                    ReporteEstadisticaDTO reporteTotales = new ReporteEstadisticaDTO
                    {
                        Partido = "Total",
                        PasesCorrectos = totalPasesCorrectos,
                        Goles = totalGoles,
                        RematesAPuerta = totalRematesAPuerta,
                        RematesAfuera = totalRematesFuera,
                        Asistencias = totalAsistencias,
                        Amarillas = totalAmarillas,
                        Rojas = totalRojas,
                        RematesAtajados = totalRematesAtajados,
                        GolesRecibidos = totalGolesRecibidos,
                        Faltas = totalFaltas
                    };
                    tablaEstadisticas.Add(reporteTotales);

                    foreach (var est in tablaEstadisticas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(est.Partido)).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PasesCorrectos.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Goles.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAfuera.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAPuerta.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Asistencias.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Amarillas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Rojas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Faltas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAtajados.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.GolesRecibidos.ToString())).SetBorderBottom(new SolidBorder(1)));
                    }
                    document.Add(table);

                    // Uso de la imagen convertida en tu PDF
                    byte[] graficoBytes = GenerarGraficoEstadisticasVoley(tablaEstadisticas);
                    ImageData graficoImageData = ImageDataFactory.Create(graficoBytes);
                    Image graficoImage = new Image(graficoImageData);
                    // Ajustar tamaño del gráfico y añadir separación del contenido anterior
                    graficoImage.ScaleToFit(400, 300);
                    graficoImage.SetMarginTop(40); // Espacio superior de 20 unidades
                    document.Add(graficoImage);
                }

                // Cerrar el documento
                document.Close();

                // Retornar el PDF generado como un byte[]
                return memoryStream.ToArray();
            }
        }

        public byte[] ReporteEstadisticaDiscEquipoPeriodo(DateTime periodoInicio, DateTime periodoFin, int idDisciplina, int idEquipo)
        {
            // Crear el PDF en memoria
            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Obtén el directorio raíz de la aplicación
                var rootPath = Directory.GetCurrentDirectory();

                // Construye la ruta a la carpeta "Images" dentro del proyecto
                var imagePath = Path.Combine(rootPath, "Images", "LogoReporte.jpeg");

                // Agregar logo
                Image logo = new Image(ImageDataFactory.Create(imagePath));
                logo.ScaleToFit(50, 50); // Cambia el tamaño a 50x50 puntos
                document.Add(logo);

                // Título
                Paragraph title = new Paragraph("Estadísticas por disciplina, equipo y periodo")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18);
                document.Add(title);

                // Fecha de generación y periodo
                DateTime fechaGeneracion = DateTime.Now;
                document.Add(new Paragraph($"Fecha de generación: {fechaGeneracion}")
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Periodo: {periodoInicio.ToShortDateString()} a {periodoFin.ToShortDateString()}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12));

                // disciplina
                Disciplina? disciplina = _disciplinasYLeccionesServices.GetDisciplinaById(idDisciplina);
                if (disciplina == null)
                {
                    throw new Exception("No existe la disciplina seleccionada");
                }
                document.Add(new Paragraph($"Disciplina: {disciplina.Nombre}")
                   .SetFontSize(12));

                // Datos del equipo
                EquipoResponseDTO equipo = _equipoServices.GetEquipoById(idEquipo);
                if (equipo == null)
                {
                    throw new Exception("No existe el equipo ingresado");
                }

                document.Add(new Paragraph($"Categoria: {equipo.Categoria.Nombre}")
                 .SetFontSize(12));

                document.Add(new Paragraph($"Nombre de equipo: {equipo.Nombre}")
                 .SetFontSize(12));

                document.Add(new Paragraph($"Lista de jugadores:")
                 .SetFontSize(12));

                foreach (var item in equipo.Jugadores)
                {
                    document.Add(new Paragraph($"{item.NumCamiseta} - {item.Nombre} {item.Apellido} ")
                    .SetFontSize(12));
                }

                // voley
                if (disciplina.Nombre == Enums.Disciplinas.Voleyball.ToString())
                {
                    // Tabla de estadisticas
                    Table table = new Table(new float[] { 4, 4, 2, 4, 2, 4, 2, 4 });
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Acciones")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("+")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje +")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("/")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje /")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("-")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Porcentaje -")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Total")).SetBorderBottom(new SolidBorder(1)));

                    // traer estadisticas por usuario en rango fechas de la disciplina
                    EstadisticaDTO estadisticasDTO = new EstadisticaDTO
                    {
                        IdDisciplina = idDisciplina,
                        FechaDesde = periodoInicio,
                        FechaHasta = periodoFin,
                        IdEquipo = idEquipo
                    };
                    List<Estadisticas> estadisticas = _partidoServices.GetEstadisticasByEquipo(estadisticasDTO);
                    List<ReporteEstadisticaDTO> tablaEstadisticas = new List<ReporteEstadisticaDTO>();

                    // Obtener las estadísticas agrupadas por el nombre del tipo de acción
                    var estadisticasAgrupadas = estadisticas
                        .GroupBy(e => e.TipoAccionPartido?.NombreTipoAccion)
                        .Where(grupo => grupo.Key != null); // Ignorar acciones sin tipo

                    foreach (var grupo in estadisticasAgrupadas)
                    {
                        var tipoAccion = grupo.Key;

                        // Filtrar por el tipo de acción actual y contar cada marca
                        int totalBien = grupo.Where(e => e.MarcaEstadistica == "+").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "+").FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int totalRegular = grupo.Where(e => e.MarcaEstadistica == "/").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "/").FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int totalMal = grupo.Where(e => e.MarcaEstadistica == "-").FirstOrDefault() != null ? grupo.Where(e => e.MarcaEstadistica == "-").FirstOrDefault()!.PuntajeTipoAccion : 0;

                        int total = totalBien + totalRegular + totalMal;

                        // Calcular porcentajes
                        int porcentajeBien = total > 0 ? (totalBien * 100) / total : 0;
                        int porcentajeRegular = total > 0 ? (totalRegular * 100) / total : 0;
                        int porcentajeMal = total > 0 ? (totalMal * 100) / total : 0;

                        // Crear un nuevo ReporteEstadisticaDTO y asignar valores
                        ReporteEstadisticaDTO reporte = new ReporteEstadisticaDTO
                        {
                            Accion = tipoAccion!,
                            Bien = totalBien,
                            PorcentajeBien = porcentajeBien,
                            Regular = totalRegular,
                            PorcentajeRegular = porcentajeRegular,
                            Mal = totalMal,
                            PorcentajeMal = porcentajeMal,
                            Total = total
                        };

                        // Añadir el reporte a la lista final
                        tablaEstadisticas.Add(reporte);
                    }

                    foreach (var est in tablaEstadisticas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(est.Accion)).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Bien.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeBien.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Regular.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeRegular.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Mal.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PorcentajeMal.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Total.ToString())).SetBorderBottom(new SolidBorder(1)));
                    }
                    document.Add(table);

                    // Uso de la imagen convertida en tu PDF
                    byte[] graficoBytes = GenerarGraficoEstadisticasVoley(tablaEstadisticas);
                    ImageData graficoImageData = ImageDataFactory.Create(graficoBytes);
                    Image graficoImage = new Image(graficoImageData);
                    // Ajustar tamaño del gráfico y añadir separación del contenido anterior
                    graficoImage.ScaleToFit(400, 300);
                    graficoImage.SetMarginTop(40); // Espacio superior de 20 unidades
                    document.Add(graficoImage);
                }

                if (disciplina.Nombre == Enums.Disciplinas.Futbol.ToString())
                {
                    // Tabla de estadisticas
                    Table table = new Table(new float[] { 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Nro Jugador")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Pases correctos")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Goles")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates afuera")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates a puerta")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Asistencias")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Amarillas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Rojas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Faltas")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Remates atajados")).SetBorderBottom(new SolidBorder(1)));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Goles recibidos")).SetBorderBottom(new SolidBorder(1)));

                    // traer estadisticas por usuario en rango fechas de la disciplina
                    EstadisticaDTO estadisticasDTO = new EstadisticaDTO
                    {
                        IdDisciplina = idDisciplina,
                        FechaDesde = periodoInicio,
                        FechaHasta = periodoFin,
                        IdEquipo = idEquipo
                    };
                    List<Estadisticas> estadisticas = _partidoServices.GetEstadisticasByEquipo(estadisticasDTO);
                    List<ReporteEstadisticaDTO> tablaEstadisticas = new List<ReporteEstadisticaDTO>();

                    // Obtener las estadísticas agrupadas por jugador
                    var estadisticasAgrupadas = estadisticas
                        .GroupBy(e => e.NroJugador)
                        .Where(grupo => grupo.Key != null); // Ignorar acciones sin tipo

                    int totalPasesCorrectos = 0;
                    int totalGoles = 0;
                    int totalRematesFuera = 0;
                    int totalRematesAPuerta = 0;
                    int totalAsistencias = 0;
                    int totalAmarillas = 0;
                    int totalRojas = 0;
                    int totalFaltas = 0;
                    int totalRematesAtajados = 0;
                    int totalGolesRecibidos = 0;

                    foreach (var grupo in estadisticasAgrupadas)
                    {
                        var jugador = grupo.Key;

                        int pasesCorrectos = grupo.Where(e => e?.TipoAccionPartido?.Id == 6).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 6).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int goles = grupo.Where(e => e?.TipoAccionPartido?.Id == 1).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 1).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesFuera = grupo.Where(e => e?.TipoAccionPartido?.Id == 9).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 9).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesAPuerta = grupo.Where(e => e?.TipoAccionPartido?.Id == 8).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 8).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int asistencias = grupo.Where(e => e?.TipoAccionPartido?.Id == 7).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 7).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int amarillas = grupo.Where(e => e?.TipoAccionPartido?.Id == 3).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 3).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rojas = grupo.Where(e => e?.TipoAccionPartido?.Id == 4).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 4).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int faltas = grupo.Where(e => e?.TipoAccionPartido?.Id == 2).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 2).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int rematesAtajados = grupo.Where(e => e?.TipoAccionPartido?.Id == 11).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 11).FirstOrDefault()!.PuntajeTipoAccion : 0;
                        int golesRecibidos = grupo.Where(e => e?.TipoAccionPartido?.Id == 12).FirstOrDefault() != null ? grupo.Where(e => e?.TipoAccionPartido?.Id == 12).FirstOrDefault()!.PuntajeTipoAccion : 0;

                        // actualizar totales
                        totalPasesCorrectos += pasesCorrectos;
                        totalGoles += goles;
                        totalRematesFuera += rematesFuera;
                        totalRematesAPuerta += rematesAPuerta;
                        totalAsistencias += asistencias;
                        totalAmarillas += amarillas;
                        totalRojas += rojas;
                        totalFaltas += faltas;
                        totalRematesAtajados += rematesAtajados;
                        totalGolesRecibidos += golesRecibidos;

                        // Crear un nuevo ReporteEstadisticaDTO y asignar valores
                        ReporteEstadisticaDTO reporte = new ReporteEstadisticaDTO
                        {
                            Partido = jugador.ToString(),
                            PasesCorrectos = pasesCorrectos,
                            Goles = goles,
                            RematesAPuerta = rematesAPuerta,
                            RematesAfuera = rematesFuera,
                            Asistencias = asistencias,
                            Amarillas = amarillas,
                            Rojas = rojas,
                            RematesAtajados = rematesAtajados,
                            GolesRecibidos = golesRecibidos,
                            Faltas = faltas
                        };

                        tablaEstadisticas.Add(reporte);
                        // Añadir el reporte a la lista final
                    }

                    // creo otra fila con los totales
                    ReporteEstadisticaDTO reporteTotales = new ReporteEstadisticaDTO
                    {
                        Partido = "Total",
                        PasesCorrectos = totalPasesCorrectos,
                        Goles = totalGoles,
                        RematesAPuerta = totalRematesAPuerta,
                        RematesAfuera = totalRematesFuera,
                        Asistencias = totalAsistencias,
                        Amarillas = totalAmarillas,
                        Rojas = totalRojas,
                        RematesAtajados = totalRematesAtajados,
                        GolesRecibidos = totalGolesRecibidos,
                        Faltas = totalFaltas
                    };
                    tablaEstadisticas.Add(reporteTotales);

                    foreach (var est in tablaEstadisticas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(est.Partido)).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.PasesCorrectos.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Goles.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAfuera.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAPuerta.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Asistencias.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Amarillas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Rojas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.Faltas.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.RematesAtajados.ToString())).SetBorderBottom(new SolidBorder(1)));
                        table.AddCell(new Cell().Add(new Paragraph(est.GolesRecibidos.ToString())).SetBorderBottom(new SolidBorder(1)));
                    }
                    document.Add(table);

                    // Uso de la imagen convertida en tu PDF
                    byte[] graficoBytes = GenerarGraficoEstadisticasFutbol(tablaEstadisticas);
                    ImageData graficoImageData = ImageDataFactory.Create(graficoBytes);
                    Image graficoImage = new Image(graficoImageData);
                    // Ajustar tamaño del gráfico y añadir separación del contenido anterior
                    graficoImage.ScaleToFit(400, 300);
                    graficoImage.SetMarginTop(40); // Espacio superior de 20 unidades
                    document.Add(graficoImage);
                }

                // Cerrar el documento
                document.Close();

                // Retornar el PDF generado como un byte[]
                return memoryStream.ToArray();
            }
        }

        private byte[] GenerarGraficoEstadisticasVoley(List<ReporteEstadisticaDTO> tabla)
        {
            // Crear el modelo de gráfico
            var plotModel = new PlotModel { Title = "Estadísticas de Acciones" };

            // Configurar el eje X con nombres de acciones
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom
            };
            foreach (var item in tabla)
            {
                categoryAxis.Labels.Add(item.Accion);
            }
            plotModel.Axes.Add(categoryAxis);

            // Configurar el eje Y para mostrar el porcentaje de 0 a 100
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = 0,
                Maximum = 100,
                Title = "Porcentaje (%)"
            };
            plotModel.Axes.Add(valueAxis);

            // Agregar series de columnas apiladas para los tres valores: Bien, Regular, Mal
            var bienSeries = new ColumnSeries { Title = "Bien", FillColor = OxyColors.Green, IsStacked = true };
            var regularSeries = new ColumnSeries { Title = "Regular", FillColor = OxyColors.Yellow, IsStacked = true };
            var malSeries = new ColumnSeries { Title = "Mal", FillColor = OxyColors.Red, IsStacked = true };

            foreach (var item in tabla)
            {
                bienSeries.Items.Add(new ColumnItem(item.PorcentajeBien) { CategoryIndex = tabla.IndexOf(item) });
                regularSeries.Items.Add(new ColumnItem(item.PorcentajeRegular) { CategoryIndex = tabla.IndexOf(item) });
                malSeries.Items.Add(new ColumnItem(item.PorcentajeMal) { CategoryIndex = tabla.IndexOf(item) });
            }

            plotModel.Series.Add(bienSeries);
            plotModel.Series.Add(regularSeries);
            plotModel.Series.Add(malSeries);

            // Configurar la leyenda para que se muestre en la parte inferior
            plotModel.LegendPosition = LegendPosition.BottomCenter;
            plotModel.LegendPlacement = LegendPlacement.Outside;
            plotModel.LegendOrientation = LegendOrientation.Horizontal;

            // Renderizar el gráfico en memoria como SVG
            byte[] svgBytes;
            using (var svgStream = new MemoryStream())
            {
                var svgExporter = new SvgExporter { Width = 800, Height = 600 };
                svgExporter.Export(plotModel, svgStream);
                svgBytes = svgStream.ToArray();
            }
            // Convertir SVG a PNG
            byte[] pngBytes = ConvertSvgToPng(svgBytes, 800, 600);
            return pngBytes;
        }

        private byte[] GenerarGraficoEstadisticasFutbol(List<ReporteEstadisticaDTO> tabla)
        {
            // Crear el modelo de gráfico
            var plotModel = new PlotModel { Title = "Estadísticas de Acciones" };

            // Configurar el eje X con nombres de acciones de futbol
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom
            };
            categoryAxis.Labels.Add("Pases y asistencias");
            categoryAxis.Labels.Add("Goles y remates");
            categoryAxis.Labels.Add("Faltas y cartulinas");
            categoryAxis.Labels.Add("Remates en contra");
            plotModel.Axes.Add(categoryAxis);

            // Calcular el valor máximo de las estadísticas para ajustar el eje Y
            int maxValue = Math.Max(
                tabla.Max(item => Math.Max(item.PasesCorrectos + item.Asistencias, item.Goles + item.RematesAPuerta + item.RematesAfuera)),
                Math.Max(tabla.Max(item => item.Faltas + item.Amarillas + item.Rojas), tabla.Max(item => item.RematesAtajados + item.GolesRecibidos))
            );

            // Configurar el eje Y para mostrar desde 0 hasta el valor máximo encontrado
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = 0,
                Maximum = maxValue,
                Title = "Totales"
            };
            plotModel.Axes.Add(valueAxis);

            // elimino la fila de totales
            tabla.RemoveAt(tabla.Count - 1);

            // Asistencias y pases
            var pasesSeries = new ColumnSeries { Title = "Pases", FillColor = OxyColors.Green, IsStacked = true };
            var asistenciasSeries = new ColumnSeries { Title = "Asistencias", FillColor = OxyColors.Yellow, IsStacked = true };
            foreach (var item in tabla)
            {
                pasesSeries.Items.Add(new ColumnItem(item.PasesCorrectos) { CategoryIndex = 0 });
                asistenciasSeries.Items.Add(new ColumnItem(item.Asistencias) { CategoryIndex = 0 });
            }
            plotModel.Series.Add(pasesSeries);
            plotModel.Series.Add(asistenciasSeries);

            // Goles, remates a puerta y remates afuera
            var golesSeries = new ColumnSeries { Title = "Goles", FillColor = OxyColors.Green, IsStacked = true };
            var rematesPuertaSeries = new ColumnSeries { Title = "Remates a puerta", FillColor = OxyColors.Yellow, IsStacked = true };
            var rematesFueraSeries = new ColumnSeries { Title = "Remates fuera", FillColor = OxyColors.Red, IsStacked = true };
            foreach (var item in tabla)
            {
                golesSeries.Items.Add(new ColumnItem(item.Goles) { CategoryIndex = 1 });
                rematesPuertaSeries.Items.Add(new ColumnItem(item.RematesAPuerta) { CategoryIndex = 1 });
                rematesFueraSeries.Items.Add(new ColumnItem(item.RematesAfuera) { CategoryIndex = 1 });
            }
            plotModel.Series.Add(golesSeries);
            plotModel.Series.Add(rematesPuertaSeries);
            plotModel.Series.Add(rematesFueraSeries);

            // Faltas, amarillas y rojas
            var faltasSeries = new ColumnSeries { Title = "Faltas", FillColor = OxyColors.Green, IsStacked = true };
            var amarillasSeries = new ColumnSeries { Title = "Amarillas", FillColor = OxyColors.Yellow, IsStacked = true };
            var rojasSeries = new ColumnSeries { Title = "Rojas", FillColor = OxyColors.Red, IsStacked = true };
            foreach (var item in tabla)
            {
                faltasSeries.Items.Add(new ColumnItem(item.Faltas) { CategoryIndex = 2 });
                amarillasSeries.Items.Add(new ColumnItem(item.Amarillas) { CategoryIndex = 2 });
                rojasSeries.Items.Add(new ColumnItem(item.Rojas) { CategoryIndex = 2 });
            }
            plotModel.Series.Add(faltasSeries);
            plotModel.Series.Add(amarillasSeries);
            plotModel.Series.Add(rojasSeries);

            // Remates atajados y goles recibidos
            var rematesAtajadosSeries = new ColumnSeries { Title = "Atajados", FillColor = OxyColors.Green, IsStacked = true };
            var golesRecibidosSeries = new ColumnSeries { Title = "Goles recibidos", FillColor = OxyColors.Red, IsStacked = true };
            foreach (var item in tabla)
            {
                rematesAtajadosSeries.Items.Add(new ColumnItem(item.RematesAtajados) { CategoryIndex = 3 });
                golesRecibidosSeries.Items.Add(new ColumnItem(item.GolesRecibidos) { CategoryIndex = 3 });
            }
            plotModel.Series.Add(rematesAtajadosSeries);
            plotModel.Series.Add(golesRecibidosSeries);

            // Configurar la leyenda para que se muestre en la parte inferior
            plotModel.LegendPosition = LegendPosition.BottomCenter;
            plotModel.LegendPlacement = LegendPlacement.Outside;
            plotModel.LegendOrientation = LegendOrientation.Horizontal;

            // Renderizar el gráfico en memoria como SVG
            byte[] svgBytes;
            using (var svgStream = new MemoryStream())
            {
                var svgExporter = new SvgExporter { Width = 800, Height = 600 };
                svgExporter.Export(plotModel, svgStream);
                svgBytes = svgStream.ToArray();
            }
            // Convertir SVG a PNG
            byte[] pngBytes = ConvertSvgToPng(svgBytes, 800, 600);
            return pngBytes;
        }

        private byte[] ConvertSvgToPng(byte[] svgBytes, int width, int height)
        {
            using (var svg = new SKSvg())
            {
                using (var stream = new MemoryStream(svgBytes))
                {
                    svg.Load(stream);
                }

                using (var bitmap = new SKBitmap(width, height))
                {
                    using (var canvas = new SKCanvas(bitmap))
                    {
                        canvas.Clear(SKColors.White);
                        canvas.DrawPicture(svg.Picture);
                    }

                    using (var image = SKImage.FromBitmap(bitmap))
                    using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
                    {
                        return data.ToArray();
                    }
                }
            }
        }







    }
}
