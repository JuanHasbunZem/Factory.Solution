using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Factory.Models;


namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.EngineerList = _db.Engineers.ToList();
      ViewBag.MachineList = _db.Machines.ToList();
      return View();
    }
  }
}