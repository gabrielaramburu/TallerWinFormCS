using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("Libro")]
    public class LibroController : Controller
    {
        private ILogger<LibroController> _logger;
        public LibroController(ILogger<LibroController> logger) { 
            _logger = logger;
        }
        

        [Route("VerLibro")]
        public IActionResult VerLibro()
        {
            _logger.LogInformation("Estamso pasando por aca");
            IList<Libro> libros = new List<Libro>();
            libros.Add(new Libro("1221321", "HolaMundo"));
            libros.Add(new Libro("45345", "LA vuelta al mundo en 80 días"));

            return View("VerLi", libros);
        }
    }
}
