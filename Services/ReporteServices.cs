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
using ApiNet8.Migrations;
using iText.Layout.Borders;
using ApiNet8.Models.Reservas;

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


        public ReporteServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IEventoServices eventoServices, IUsuarioServices usuarioServices, ITipoEventoServices tipoEventoServices, IInstalacionServices instalacionServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _eventoServices = eventoServices;
            _usuarioServices = usuarioServices;
            _tipoEventoServices = tipoEventoServices;
            _instalacionServices = instalacionServices;
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
                TipoEvento? tipoEvento= _tipoEventoServices.GetTipoEventoById(idTipoEvento);
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






    }
}
