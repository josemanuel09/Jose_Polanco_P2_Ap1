using Microsoft.EntityFrameworkCore;
using Jose_Polanco_P2_Ap1.Shared.Models;


namespace Jose_Polanco_P2_Ap1.Api.DAL
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {

        }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Accesorios> Accesorios { get; set; }
        public DbSet<VehiculosDetalle> VehiculosDetalle { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Accesorios>().HasData(new List<Accesorios>()
            {
                new Accesorios() { AccesorioId = 1, Descripcion = "Camara Trasera" },
                new Accesorios() { AccesorioId = 2, Descripcion =  "Pantalla Interior"},
                new Accesorios() { AccesorioId = 3, Descripcion= "Interior en piel" },
                new Accesorios() { AccesorioId = 4, Descripcion = "Sun Roof" },
                new Accesorios() { AccesorioId = 5, Descripcion = "Aros de Lujo" }
               
            });


        }

    }
}
