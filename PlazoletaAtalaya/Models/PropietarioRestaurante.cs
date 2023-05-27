namespace PlazoletaAtalaya.Models
{
    public class PropietarioRestaurante : TipoUsuario
    {
        public string Cargo { get; private set; }

        public string NombreRestaurante { get; set; }

        public List<Empleado> Empleados { get; set; }
        
        private PropietarioRestaurante()
        {

        }
        
        public PropietarioRestaurante(string cedula, string nombre, int edad, string telefono, string correo, string cargo, string nombreRestaurante)
                                      : base(cedula, nombre, edad, telefono, correo)
        {
            this.Cargo = cargo;
            this.NombreRestaurante = nombreRestaurante;
        }

        /// <summary>
        /// Logica de dominio
        /// </summary>
        /// <param name="cargo"></param>
        public void cambiarAtributosPrincipalesPropietario(string cargo)
        {
            if (cargo != "administrador" && cargo != "cajero" && cargo != "cocinero" && cargo != "mesero")
            {
                Console.WriteLine("El cargo del empleado que esta tratando de introducir no existe");
                Console.WriteLine("Los cargos habilitados para modificar son: administrador, cajero, cocinero y mesero.");

            }
        }
        

    }
}
