
using PlazoletaAtalaya.Models;


namespace PlazoletaAtalaya.DB
{
    public class PropietarioRestauranteRepository
    {
        private readonly PlazoletaContext context;

        public PropietarioRestauranteRepository(PlazoletaContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Este metodo guarda en la base de datos el usuario propietario que deseemos
        /// </summary>
        /// <param name="propietarioRestaurante"></param>
        /// <exception cref="Exception"></exception>
        public void saveOwner(PropietarioRestaurante propietarioRestaurante)
        {
            try
            {
                //Este metodo guarda
                this.context.Add(propietarioRestaurante);

                //Confirmamos
                this.context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Este metodo verifica si el usuario propietario que se va a crear existe en la base de datos
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool thereIsOwner(string cedula)
        {
            try
            {
                var existe = this.context.PropietariosRestaurantes.FirstOrDefault(x => x.Cedula == cedula);

                if (existe == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public PropietarioRestaurante getByIdAdministradorPlazoleta(string cedula)
        {
            try
            {
                return this.context.PropietariosRestaurantes.FirstOrDefault(x => x.Cedula == cedula);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Este metodo funciona para traer un usuario propietario que se encuentra en la base de datos indicando la cedula del propietario
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public PropietarioRestaurante getPropietario(string cedula)
        {
            try
            {
                return this.context.PropietariosRestaurantes.FirstOrDefault(x => x.Cedula == cedula);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Este metodo sirve para traer todos los usuarios propietarios que se encuentran almacenados en la base de datos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<PropietarioRestaurante> getAllPropietarios()
        {
            try
            {
                return (List<PropietarioRestaurante>)this.context.PropietariosRestaurantes.ToList();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Funcion para borar un usuario propietario en la base de datos
        /// </summary>
        /// <param name="PropietarioRestaurante"></param>
        public void deleteOwner(PropietarioRestaurante PropietarioRestaurante)
        {
            try
            {
                this.context.Remove(PropietarioRestaurante);

                //Confirmamos el cambio en la base 
                this.context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
