using Microsoft.AspNetCore.Mvc;

namespace RazerViewExamples.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
