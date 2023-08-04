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
            _db.Engineer.Add(engineer);
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
            
        }



    }
}