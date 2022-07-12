using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchiController : Controller
  {
    [HttpGet("/tamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchi")]
    public ActionResult Create(string description)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(description);
      return RedirectToAction("Index");
    }

    
  }
}