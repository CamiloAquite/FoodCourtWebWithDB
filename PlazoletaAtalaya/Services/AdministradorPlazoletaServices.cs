using PlazoletaAtalaya.DB;
using PlazoletaAtalaya.Models;

namespace PlazoletaAtalaya.Services
{
    public class AdministradorPlazoletaServices
    {
        private readonly AdministradorPlazoletaRepository administradorPlazoletaRepository;

        public AdministradorPlazoletaServices(AdministradorPlazoletaRepository administradorPlazoletaRepository)
        {
            this.administradorPlazoletaRepository= administradorPlazoletaRepository;
        }

        /// <summary>
        /// Metodo para crear un usuario administrador en la base de datos
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="cargo"></param>
        public void crearAdministradorPlazoleta(string cedula, string nombre, int edad, string telefono, string correo, string cargo)
        {
            //
            AdministradorPlazoleta administradorPlazoleta;

            //Verificacion
            if (nombre == null)
            {
                Console.WriteLine("No se puede pasar el nombre");
            }
            else if (string.IsNullOrEmpty(cedula))
            {
                Console.WriteLine("No se pasa la cedula");
            }
            else if (edad == null)
            {
                Console.WriteLine("No se puede pasar la edad");
            }
            else if (telefono == null)
            {
                Console.WriteLine("No se puede pasar el telefono");
            }
            else if (correo == null) {
                Console.WriteLine("No se puede pasar el correo");
            }
            else if (cargo == null)
            {
                Console.WriteLine("No se puede pasar el cargo");
            }

            //Verificamos si existe en la DB
            this.administradorPlazoletaRepository.thereIsOwner(cedula);

            //Crear Objeto
            administradorPlazoleta = new(cedula, nombre, edad, telefono, correo, cargo);

            ///Guardamos el objeto en la DB
            this.administradorPlazoletaRepository.saveOwner(administradorPlazoleta);
        } 

        /// <summary>
        /// Metodo para obtener un usuario administrador mediante la cedula
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public AdministradorPlazoleta getAdministradorXCedula(string cedula)
        {   
            if(cedula is null)
                throw new NullReferenceException("No hay nombre no se puede pasar (es nulo)");

            return administradorPlazoletaRepository.getAdministrador(cedula);
        }

        /// <summary>
        /// Metodo para obtener todos los usuario administradores
        /// </summary>
        /// <returns></returns>
        public List<AdministradorPlazoleta> getAllAdministradores()
        {
            return administradorPlazoletaRepository.getAllAdministradores();
        }

        /// <summary>
        /// Metodo para borrar un usuario administrador de la base de datos mediante la cedula
        /// </summary>
        /// <param name="cedula"></param>
        public void deteleAdmin(string cedula)
        {
            AdministradorPlazoleta administradorPlazoleta;

            administradorPlazoleta = getAdministradorXCedula(cedula);

            this.administradorPlazoletaRepository.deleteAdmin(administradorPlazoleta);

        }
    }
}
