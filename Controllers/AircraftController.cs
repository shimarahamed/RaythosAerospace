using Microsoft.AspNetCore.Mvc;

namespace RaythosAerospace.Controllers
{
    public class AircraftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllAirCrafts()
        {

            return View();
        }
    }
}
