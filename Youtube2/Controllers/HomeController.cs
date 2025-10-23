using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Youtube2.Models;

namespace Youtube2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Buscar()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Video(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                // Si la URL es /watch (v es null), aquí manejas lo que quieres que pase
                ViewBag.Mensaje = "No se ha especificado un ID de perfil.";
                // podrías redirigir o simplemente mostrar una vista sin datos
                return RedirectToAction("Index");
            }
            ViewBag.PerfilId = v;
            return View();
        }

        public IActionResult Perfil(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                // Si la URL es /watch (v es null), aquí manejas lo que quieres que pase
                ViewBag.Mensaje = "No se ha especificado un ID de perfil.";
                // podrías redirigir o simplemente mostrar una vista sin datos
                return RedirectToAction("Index");
            }

            // Si la URL es /watch/algun-id (v tiene un valor)
            // Aquí buscas el perfil en tu base de datos o servicio con ese ID
            ViewBag.PerfilId = v;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
