using Microsoft.AspNetCore.Mvc;

namespace TreatFlavor.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}