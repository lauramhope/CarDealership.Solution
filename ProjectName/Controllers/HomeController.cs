using ProjectName.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassName.Controllers
{
  public class ClassNameController : Controller
  {
    [HttpGet("/route")]
    public ActionResult MethodName()
    {
      return View();
    }
  }
}