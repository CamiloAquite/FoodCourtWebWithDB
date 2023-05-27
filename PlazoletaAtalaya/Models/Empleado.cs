namespace PlazoletaAtalaya.Models
{
    public class Empleado : TipoUsuario
    {

        public string Cargo { get; private set; }
        
        public string NombreRestaurante { get; set; }

        public PropietarioRestaurante PropietarioRestaurante { get; set; }
        //LlaveForanea 
        public int PropietarioRestauranteId { get; set; }
        
        
        private Empleado()
        {

        }
        
        public Empleado(string cedula, string nombre,int edad, string telefono, string correo, string cargo,string nombreRestaurante,int propietarioRestauranteId)
                        : base(cedula, nombre, edad, telefono, correo)
        {
            this.Cargo = cargo;
            this.NombreRestaurante = nombreRestaurante;
            this.PropietarioRestauranteId = propietarioRestauranteId;
        }

        public void cambiarAtributosPrincipalesempleado(string cargo)
        {
            if (cargo != "administrador" && cargo != "cajero" && cargo != "cocinero" && cargo != "mesero")
            {
                Console.WriteLine("El cargo del empleado que esta tratando de introducir no existe");
            }else {
                this.Cargo=cargo;
            }
        }
    }
}
