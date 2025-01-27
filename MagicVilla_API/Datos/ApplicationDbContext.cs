using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la Villa Real",
                    ImageUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 500,
                    Tarifa = 200,
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Pago",
                    Detalle = "Detalle de Vailla Pago",
                    ImageUrl = "",
                    Ocupantes = 10,
                    MetrosCuadrados = 700,
                    Tarifa = 300,
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now,
                });
        }

        public DbSet<Villa> Villas { get; set; }

    }
}
