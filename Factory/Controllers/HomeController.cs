using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

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
      ViewBag.AllEngineers = new List<Engineer>(_db.Engineers.OrderBy(engineer => engineer.EngineerName));
      ViewBag.AllMachines = new List<Machine>(_db.Machines.OrderBy(machine => machine.MachineName));
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }
  }
}