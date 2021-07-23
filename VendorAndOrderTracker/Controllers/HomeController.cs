using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrderTracker.Controller
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