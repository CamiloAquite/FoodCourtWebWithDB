
using PlazoletaAtalaya.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlazoletaAtalaya.DB
{
    public class AdministradorPlazoletaRepository
    {
        private readonly PlazoletaContext context; 

        public AdministradorPlazoletaRepository( PlazoletaContext context )
        {
            this.context = context;
        }

        /// <summary>
        /// Este metodo sirve para guardar un usuario administrador en la base de datos
        /// </summary>
        /// <param name="administradorPlazoleta"></param>
        /// <exception cref="Exception"></exception>
        public void saveOwner(AdministradorPlazoleta administradorPlazoleta )
        {
            try
            {
                //Este metodo guarda
                this.context.Add(administradorPlazoleta);

                //Confirmamos
                this.context.SaveChanges();
            }
            catch(Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Este metodo se utiliza para eliminar usuario administrador dentro de la base de datos
        /// </summary>
        /// <param name="administradorPlazoleta"></param>
        public void deleteAdmin(AdministradorPlazoleta administradorPlazoleta)
        {
            try
            {
                this.context.Remove(administradorPlazoleta) ;

                //Confirmamos el cambio en la base 
                this.context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Este metodo verifica si el usuario que se creara existe
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool thereIsOwner(string cedula) 
        {
            try
            {
                var existe = this.context.AdministradoresPlazoleta.FirstOrDefault(x => x.Cedula == cedula);

                if (existe == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public AdministradorPlazoleta getByIdAdministradorPlazoleta(string cedula)
        {
            try
            {
                return this.context.AdministradoresPlazoleta.FirstOrDefault(x => x.Cedula == cedula);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public AdministradorPlazoleta getAdministrador(string cedula)
        {
            try
            {
                return this.context.AdministradoresPlazoleta.FirstOrDefault(x => x.Cedula == cedula);


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<AdministradorPlazoleta> getAllAdministradores()
        {
            try
            {
                return (List<AdministradorPlazoleta>)this.context.AdministradoresPlazoleta.ToList();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
