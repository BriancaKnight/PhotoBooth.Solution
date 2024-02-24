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

  public ActionResult Edit(int id)
  {
    Booth booth = Booth.GetDetails(id);
    return View(booth);
  }

  [HttpPost]
  public ActionResult Edit(Booth booth)
  {
    Booth.Put(booth);
    return RedirectToAction("Details", new { id = booth.BoothId});
  }

  public ActionResult Delete(int id)
  {
    Booth booth = Booth.GetDetails(id);
    return View(booth);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Booth.Delete(id);
    return RedirectToAction("Index", "Home");
  }
}