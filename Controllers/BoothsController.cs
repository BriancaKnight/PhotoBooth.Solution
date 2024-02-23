using Microsoft.AspNetCore.Mvc;
using PhotoBooth.Models;

namespace PhotoBooth.Controllers;

public class BoothsController : Controller
{
  public IActionResult Index()
  {
    List<Booth> booths = Booth.GetBooths();
    return View(booths);
  }
}