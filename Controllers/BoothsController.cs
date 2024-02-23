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

  public IActionResult Details(int id)
  {
    Booth booth = Booth.GetDetails(id);
    return View(booth);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Booth booth)
  {
    Booth.Post(booth);
    return RedirectToAction("Index");
  }
}