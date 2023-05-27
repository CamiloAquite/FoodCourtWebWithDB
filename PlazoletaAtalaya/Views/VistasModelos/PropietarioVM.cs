using PlazoletaAtalaya.Models;

namespace PlazoletaAtalaya.Views.VistasModelos
{
    public class PropietarioVM
    {
        public int idPropietario;
        public string nombrePropietario;
        public int edadPropietario;
        public string telefonoPropietario;
        public string correoPropietario;
        public string cargoPropietario;
        public string nombreRestaurantePropietario;
        public List<Empleado> empleado;

        public PropietarioVM(int idPropietario, string nombrePropietario, int edadPropietario, string telefonoPropietario, 
                            string correoPropietario, string cargoPropietario, string nombreRestaurantePropietario, 
                            List<Empleado> empleado)
        {
            this.idPropietario = idPropietario;
            this.nombrePropietario = nombrePropietario;
            this.edadPropietario = edadPropietario;
            this.telefonoPropietario = telefonoPropietario;
            this.correoPropietario = correoPropietario;
            this.cargoPropietario = cargoPropietario;
            this.nombreRestaurantePropietario = nombreRestaurantePropietario;
            this.empleado = empleado;
        }

        //DTO que mezcla diferentes tablas y transferencias de datos
    }
}
