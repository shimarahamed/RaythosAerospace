using Microsoft.AspNetCore.Mvc;

namespace RaythosAerospace.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
