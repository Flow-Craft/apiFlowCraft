using ApiNet8.Data;
using ApiNet8.Models;

namespace ApiNet8.Services
{
    public class PartidosServices
    {
        private readonly ApplicationDbContext db;
        public PartidosServices(ApplicationDbContext db)
        {
                this.db = db;
        }

        public List<Partidos> GetPartidos()
        {
            return db.Partidos.ToList();
        }

        public Partidos GetPartidos(int id) 
        {
            try
            {
                Partidos? partido = db.Partidos.Find(id);

                return partido;
            }
            catch (Exception)
            {

                throw;
            }           
        }

        public void CreatePartido(Partidos partido)
        {
            db.Partidos.Add(partido);
            db.SaveChanges();
        }

        public Boolean PartidoExist(Partidos partido) 
        {
            var partidoExist = db.Partidos.FirstOrDefault(x =>
            !string.IsNullOrWhiteSpace(x.Name) &&
            !string.IsNullOrWhiteSpace(partido.Name) &&
            x.Name.ToLower() == partido.Name.ToLower() &&
            !string.IsNullOrWhiteSpace(x.Resultado) &&
            !string.IsNullOrWhiteSpace(partido.Resultado) &&
            x.Resultado.ToLower() == partido.Resultado.ToLower() &&
            !string.IsNullOrWhiteSpace(x.EquipoA) &&
            !string.IsNullOrWhiteSpace(partido.EquipoA) &&
            x.EquipoA.ToLower() == partido.EquipoA.ToLower() &&
            !string.IsNullOrWhiteSpace(x.EquipoB) &&
            !string.IsNullOrWhiteSpace(partido.EquipoB) &&
            x.EquipoB.ToLower() == partido.EquipoB.ToLower());

            if (partidoExist != null)
            {
                return true;
            }

            return false;            
        }


    }
}
