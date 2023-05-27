using PlazoletaAtalaya.DB;
using PlazoletaAtalaya.Models;
using PlazoletaAtalaya.Views.VistasModelos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlazoletaAtalaya.Services
{
    public class PropietarioRestauranteServices
    {

        private readonly PropietarioRestauranteRepository PropietarioRestauranteRepository;

        public PropietarioRestauranteServices(PropietarioRestauranteRepository propietarioRestauranteRepository)
        {
            this.PropietarioRestauranteRepository = propietarioRestauranteRepository;
        }

        /// <summary>
        /// Metodo para crear un usuario propietario
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="cargo"></param>
        /// <param name="nombreRestaurante"></param>
        public void crearPropietarioRestaurante(string cedula, string nombre, int edad, string telefono, string correo, string cargo, string nombreRestaurante)
        {
            PropietarioRestaurante propietarioRestaurante;

            if (cedula == null)
            {
                Console.WriteLine("No se puede pasar el nombre");
            }
            else if (nombre == null)
            {
                Console.WriteLine("No se pasa el ID");
            }
            else if (edad == null)
            {
                Console.WriteLine("No se puede pasar la edad");
            }
            else if (telefono == null)
            {
                Console.WriteLine("No se puede pasar el telefono");
            }
            else if (correo == null)
            {
                Console.WriteLine("No se puede pasar el correo");
            }
            else if (nombreRestaurante == null)
            {
                Console.WriteLine("No se puede pasar el cargo");
            }

            this.PropietarioRestauranteRepository.thereIsOwner(cedula);

            propietarioRestaurante = new PropietarioRestaurante(cedula,nombre,edad,telefono,correo,cargo,nombreRestaurante);

            this.PropietarioRestauranteRepository.saveOwner(propietarioRestaurante);
        }

        /// <summary>
        /// Metodo para obtener un usuario mediante la cedula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public PropietarioRestaurante getPropietarioXCedula(string cedula)
        {
            if (cedula is null)
                throw new NullReferenceException();

            return PropietarioRestauranteRepository.getPropietario(cedula);
        }

        /// <summary>
        /// Metodo para obtener todos los usuarios por cedula
        /// </summary>
        /// <returns></returns>
        public List<PropietarioRestaurante> getAllByCedula()
        {
            return PropietarioRestauranteRepository.getAllPropietarios();
        }

        /// <summary>
        /// Metodo para borrar usuario propietario
        /// </summary>
        /// <param name="cedula"></param>
        public void deteleOwner(string cedula)
        {
            PropietarioRestaurante propietarioRestaurante;

            propietarioRestaurante = getPropietarioXCedula(cedula);

            this.PropietarioRestauranteRepository.deleteOwner(propietarioRestaurante);

        }
        /*
        public List<Empleado>GetAllEmpleadoByName(string nombre)
        {
            if (nombre is null)
                throw new NullReferenceException("No hay nombre (es nulo) por lo tanto no se puede crear.!!!");

            return PropietarioRestauranteRepository.GetAllEmpleados(nombre);
        }

        public List<Empleado> GetAllEmpleadoByName()
        {
           
            return PropietarioRestauranteRepository.GetAllEmpleados();
        }
        */

    }
}
