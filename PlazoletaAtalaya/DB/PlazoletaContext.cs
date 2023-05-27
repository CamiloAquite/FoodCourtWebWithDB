using Microsoft.EntityFrameworkCore;
using PlazoletaAtalaya.Models;

namespace PlazoletaAtalaya.DB
{
    public class PlazoletaContext : DbContext
    {
        public DbSet<AdministradorPlazoleta> AdministradoresPlazoleta { get; set; }
        public DbSet<PropietarioRestaurante> PropietariosRestaurantes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        public PlazoletaContext(DbContextOptions<PlazoletaContext> dbContext) 
               : base(dbContext)
        {

        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            var administradorPlazoleta = new AdministradorPlazoleta("1075256701", "Camilo", 26, 
                "3168257698", "correoAdministrador@correo.com", "Administrador Plazoleta");

            modelBuilder.Entity<AdministradorPlazoleta>().HasData(administradorPlazoleta);
            

            var propietarioRestaurante = new PropietarioRestaurante("1075000700", "Paola P", 48, "3208543169",
                                                                    "Correo@correo.com", "Propietario", "Restaurante el Colombiano");

            modelBuilder.Entity<PropietarioRestaurante>().HasData(propietarioRestaurante);

            modelBuilder.Entity<Empleado>().HasData(new Empleado("1075296701", "Camilo Aquite", 24, "3208545522", "Correo@correo.com", "Cajero", 
                                                                 "El restaurante Colombiano", propietarioRestaurante.Id));
            modelBuilder.Entity<Empleado>().HasData(new Empleado("1075296702", "Sebastian Aquite", 21, "3208541422", "Correo1@correo.com", "Mesero(a)",
                                                                 "El restaurante Colombiano", propietarioRestaurante.Id));
            modelBuilder.Entity<Empleado>().HasData(new Empleado("1075296703", "Camila Gutierrez", 26, "3208316038", "Correo2@correo.com", "Mesero(a)", 
                                                                 "El restaurante Colombiano", propietarioRestaurante.Id));
            modelBuilder.Entity<Empleado>().HasData(new Empleado("1075296704", "Natalia Garcia", 23, "3204522145", "Correo3@correo.com", "Cocinero(a)",
                                                                 "El restaurante Colombiano", propietarioRestaurante.Id));
            ;

        }*/
    }
}
