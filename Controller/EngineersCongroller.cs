using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
    public class EngineersController : Controller
    {
        private readonly FactoryContext _db;

        public EngineersController(FactoryContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Engineer> model = _db.Engineers.ToList();
            return View(model);
        }
        public ActionResult Create()
        {

            return View();
        }

[HttpPost]
        public ActionResult Create(Engineer engineer)
        { 
            _db.Engineers.Add(engineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

//Engineering details
        public ActionResult Details(int id)
        {
            Engineer thisEngineer = _db.Engineers
            .Include(engineer => engineer.JoinEntities)
            .ThenInclude(join => join.Machine)
            .FirstOrDefault(engineer => engineer.EngineerId == id);
            return View(thisEngineer);
        }

        public ActionResult Edit(int id)
        {
            Engineer thisEngineer = _db.Engineers
            .FirstOrDefault(engineer => engineer.EngineerId == id);
            return View(thisEngineer);
        }
        [HttpPost]
        public ActionResult Edit(Engineer engineer)
        {
            _db.Engineers.Update(engineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Engineer thisEngineer = _db.Engineers
            .FirstOrDefault(engineer => engineer.EngineerId == id);
            return View(thisEngineer);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Engineer thisEngineer = _db.Engineers
            .FirstOrDefault(engineer => engineer.EngineerId == id);
            _db.Engineers.Remove(thisEngineer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
       public ActionResult AddMachine(int id)
        {
            Engineer thisEngineer = _db.Engineers
                            .FirstOrDefault(engineers => engineers.EngineerId == id);
            List<Machine> machines = _db.Machines.ToList();
            SelectList machineList = new SelectList(machines, "MachineId", "MachineName");
            ViewBag.MachineId = machineList;
            return View(thisEngineer);
        }

         [HttpPost]
        public ActionResult AddMachine(Engineer engineer, int machineId)
        {   
            #nullable enable
            EngineerMachine? joinEntity = _db.EngineerMachines
                                .FirstOrDefault(join => (join.MachineId == machineId && join.EngineerId == engineer.EngineerId));
            #nullable disable
            if (joinEntity == null && machineId != 0)
            {
                _db.EngineerMachines.Add(new EngineerMachine() { MachineId = machineId, EngineerId = engineer.EngineerId });
                _db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = engineer.EngineerId });
        }
    }
}