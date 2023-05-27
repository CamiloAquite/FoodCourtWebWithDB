using Microsoft.AspNetCore.Mvc;
using PlazoletaAtalaya.Models;
using PlazoletaAtalaya.Services;

namespace PlazoletaAtalaya.Controllers
{
    public class AdministradorPlazoletaController : Controller
    {
        private readonly AdministradorPlazoletaServices administradorPlazoletaServices;

        public AdministradorPlazoletaController (AdministradorPlazoletaServices administradorPlazoletaServices)
        {
            this.administradorPlazoletaServices = administradorPlazoletaServices;
        }

        /// <summary>
        /// Vista general administradores (genera un listado de usuarios administradores)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            List<AdministradorPlazoleta> administradoresPlazoleta;

            administradoresPlazoleta =  this.administradorPlazoletaServices.getAllAdministradores();    

            return View(administradoresPlazoleta);
        }

        [HttpGet]
        public IActionResult CrearAdmin()
        {
            return View();
        }

        /// <summary>
        /// Crear usuario administrador
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="cargo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CrearAdmin(string cedula, string nombre, int edad, string telefono, string correo, string cargo)
        {
            administradorPlazoletaServices.crearAdministradorPlazoleta(cedula, nombre, edad, telefono, correo, cargo); 
            
            return RedirectToAction("Index", "administradorPlazoleta");
        }

        [HttpGet]
        public IActionResult BorrarAdmin()
        {
            return View();
        }

        /// <summary>
        /// Borrar usuario administrador
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult BorrarAdmin(string cedula)
        {
            administradorPlazoletaServices.deteleAdmin(cedula);

            return RedirectToAction("Index", "administradorPlazoleta");
        }
    }
}
