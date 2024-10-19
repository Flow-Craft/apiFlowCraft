using ApiNet8.Data;
using ApiNet8.Services.IServices;
using AutoMapper;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using static System.Net.Mime.MediaTypeNames;
//using System.Reflection.Metadata;
//using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Layout.Properties;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models.Eventos;
using ApiNet8.Migrations;

namespace ApiNet8.Services
{
    public class ReporteServices : IReporteServices
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEventoServices _eventoServices;
        private readonly IUsuarioServices _usuarioServices;        

        public ReporteServices(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor, IEventoServices eventoServices, IUsuarioServices usuarioServices)
        {
            this._db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _eventoServices = eventoServices;
            _usuarioServices = usuarioServices;
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
                document.Add(new Paragraph($"Periodo: {periodoInicio} a {periodoFin}")
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
                Table table = new Table(4, true); // 4 columnas
                table.AddHeaderCell("Evento");
                table.AddHeaderCell("Instalación");
                table.AddHeaderCell("Fecha Evento");
                table.AddHeaderCell("Tipo Evento");

                // traer asistencias por usuario en rango fechas
                List<Asistencia> asistenciasUsuario = _eventoServices.GetAsistenciasByUsuarioAndPeriodo(idUsuario, periodoInicio, periodoFin);

                foreach (var evento in asistenciasUsuario)
                {
                    table.AddCell(evento.Evento.Titulo);
                    table.AddCell(evento.Evento.Instalacion.Nombre);
                    table.AddCell(evento.Evento.FechaInicio.ToString());
                    table.AddCell(evento.Evento.TipoEvento.NombreTipoEvento);
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







    }
}
