using ApiNet8.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiNet8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Partidos> Partidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // aquí se pueden modificar nombres de tablas y columnas, cargar data inicial(estados iniciales)

            // data seeding
            modelBuilder.Entity<Partidos>().HasData(
                new Partidos { Id = 1, EquipoA="Independiente", EquipoB="Boca", Name="Fecha 1 copa de la liga", Resultado="2-0"});
        }
    }
}
