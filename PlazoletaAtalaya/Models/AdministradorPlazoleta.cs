namespace PlazoletaAtalaya.Models
{
    public class AdministradorPlazoleta : TipoUsuario
    {
        public string Cargo {get; set;}

        private AdministradorPlazoleta()
        {

        }
        
        public AdministradorPlazoleta(string cedula,string nombre, int edad, string telefono, string correo, string cargo)
                                     : base(cedula, nombre, edad, telefono, correo)
        {
            this.Cargo = cargo;
        }
    }
}
