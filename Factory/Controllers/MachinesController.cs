using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine Machine, int EngineerId)
    {
      _db.Machines.Add(Machine);
      _db.SaveChanges();
      _db.EngineerMachine.Add(new EngineerMachine() {EngineerId = EngineerId, MachineId = Machine.MachineId });
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Edit(int id)
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult Edit (Machine machine)
    {
      _db.Entry(machine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = machine.MachineId });
    }
     public ActionResult Delete(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      _db.Machines.Remove(thisMachine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
        public ActionResult AddEngineer(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View(thisMachine);
    }

    [HttpPost]

public ActionResult AddEngineer(Machine machine, int engineerId)
    {
      if (engineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { MachineId = machine.MachineId, EngineerId = engineerId});
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = machine.MachineId});
    }
    public ActionResult Details(int id)
    {
      var thisMachine = _db.Machines  
      .Include(machine => machine.JoinEntities) 
      .ThenInclude(join => join.Machine)
      .FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);  
    }

  }
}