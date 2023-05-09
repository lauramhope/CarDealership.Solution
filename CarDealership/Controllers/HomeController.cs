using CarDealership.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/route")]
    public ActionResult MethodName()
    {
      return View();
    }
  }
}