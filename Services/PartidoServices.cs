using ApiNet8.Data;
using ApiNet8.Models.Partidos;

namespace ApiNet8.Services
{
    public class PartidoServices
    {
        private readonly ApplicationDbContext db;
        public PartidoServices(ApplicationDbContext db)
        {
                this.db = db;
        }

        public List<Partido> GetPartidos()
        {
            return db.Partidos.ToList();
        }

        public Partido GetPartidos(int id) 
        {
            try
            {
                Partido? partido = db.Partidos.Find(id);

                return partido;
            }
            catch (Exception)
            {

                throw;
            }           
        }

        //public void CreatePartido(Partido partido)
        //{
        //    db.Partidos.Add(partido);
        //    db.SaveChanges();
        //}

        //public Boolean PartidoExist(Partido partido) 
        //{
        //    var partidoExist = db.Partidos.FirstOrDefault(x =>
        //    !string.IsNullOrWhiteSpace(x.Name) &&
        //    !string.IsNullOrWhiteSpace(partido.Name) &&
        //    x.Name.ToLower() == partido.Name.ToLower() &&
        //    !string.IsNullOrWhiteSpace(x.Resultado) &&
        //    !string.IsNullOrWhiteSpace(partido.Resultado) &&
        //    x.Resultado.ToLower() == partido.Resultado.ToLower() &&
        //    !string.IsNullOrWhiteSpace(x.EquipoA) &&
        //    !string.IsNullOrWhiteSpace(partido.EquipoA) &&
        //    x.EquipoA.ToLower() == partido.EquipoA.ToLower() &&
        //    !string.IsNullOrWhiteSpace(x.EquipoB) &&
        //    !string.IsNullOrWhiteSpace(partido.EquipoB) &&
        //    x.EquipoB.ToLower() == partido.EquipoB.ToLower());

        //    if (partidoExist != null)
        //    {
        //        return true;
        //    }

        //    return false;            
        //}


    }
}
