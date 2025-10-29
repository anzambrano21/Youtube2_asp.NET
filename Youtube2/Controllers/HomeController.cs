using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using Youtube2.Models;

namespace Youtube2.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;
        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient(); ;
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
        public async Task<IActionResult> video(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                // Si la URL es /watch (v es null), aquí manejas lo que quieres que pase
                ViewBag.Mensaje = "No se ha especificado un ID de perfil.";
                // podrías redirigir o simplemente mostrar una vista sin datos
                return RedirectToAction("Index");
            }
            ViewBag.PerfilId = v;
            try
            {
                
                var Url2= $"https://localhost:7004/api/videos/{v}";

                
                var response2 = await _httpClient.GetAsync(Url2);

                // Verificamos si la respuesta fue exitosa
                if (!response2.IsSuccessStatusCode)
                {
                    // Puedes registrar o mostrar un mensaje de error si lo deseas 
                    
                    return RedirectToAction("Index"); // o View() si prefieres mostrar una vista vacía
                }

                
                var json2 = await response2.Content.ReadAsStringAsync();
                

                // Validamos si el contenido está vacío o es nulo
                if ((string.IsNullOrWhiteSpace(json2) || json2 == "[]" || json2 == "{}"))
                {
                    ViewBag.Mensaje = "No hay comentarios disponibles para este video.";
                    return RedirectToAction("Index"); // Podrías retornar la vista con un mensaje vacío
                }

               
                return View();

            }
            catch (HttpRequestException ex)
            {
                ViewBag.Mensaje = "Error al obtener los comentarios del perfil.";
                // Opcional: loguear el error o manejarlo según tu lógica
                return RedirectToAction("Index");
            }
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
