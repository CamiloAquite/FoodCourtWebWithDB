using Microsoft.AspNetCore.Mvc;
using PlazoletaAtalaya.Models;
using PlazoletaAtalaya.Services;

namespace PlazoletaAtalaya.Controllers
{
    public class PropietarioRestauranteController : Controller
    {
        private readonly PropietarioRestauranteServices propietarioRestauranteServices;


        public PropietarioRestauranteController (PropietarioRestauranteServices propietarioRestauranteServices)
        {
            this.propietarioRestauranteServices = propietarioRestauranteServices;
        }

        /// <summary>
        /// Vista general propietarios (genera un listado de usuarios propietarios)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult IndexPropie()
        {
            List<PropietarioRestaurante> PropietariosRestaurantes;

            PropietariosRestaurantes = this.propietarioRestauranteServices.getAllByCedula();

            return View(PropietariosRestaurantes);
        }

        [HttpGet]
        public IActionResult CrearProp()
        {
            return View();

        }

        /// <summary>
        /// Creacion de propietario
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="cargo"></param>
        /// <param name="nombreRestaurante"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CrearProp(string cedula, string nombre, int edad, string telefono,string correo, 
                                       string cargo, string nombreRestaurante)
        {
            propietarioRestauranteServices.crearPropietarioRestaurante(cedula, nombre, edad, telefono,correo, cargo, nombreRestaurante);

            return RedirectToAction("IndexPropie", "PropietarioRestaurante");
        }

        [HttpGet]
        public IActionResult BorrarProp()
        {
            return View();

        }

        /// <summary>
        /// Borrar propietario de la DB
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult BorrarProp(string cedula) 
        {
            propietarioRestauranteServices.deteleOwner(cedula);

            return RedirectToAction("IndexPropie", "PropietarioRestaurante");
        }
    }
}
