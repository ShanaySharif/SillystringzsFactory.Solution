using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;

namespace DoctorsOffice.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly DoctorsOfficeContext _db;

        public DoctorsController(DoctorsOfficeContext db)
        {
            _db = db;
        }
        public ActionResult Index()
    }
}