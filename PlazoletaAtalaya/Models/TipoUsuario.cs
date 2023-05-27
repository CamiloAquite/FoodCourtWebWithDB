using System.ComponentModel.DataAnnotations;

namespace PlazoletaAtalaya.Models
{
    public abstract class TipoUsuario
    {
        [Key]
        public int Id { get; set; }

        public string Cedula { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public TipoUsuario()
        {
        }

        public TipoUsuario(string cedula, string nombre, int edad, string telefono, string correo)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Telefono = telefono;
            this.Correo = correo;
        }
    }
}
