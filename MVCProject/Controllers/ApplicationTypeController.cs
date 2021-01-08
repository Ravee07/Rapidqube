using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Data;
using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationType;
            return View(objList);

        }

        public IActionResult create()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(ApplicationType obj)
        {
            _db.ApplicationType.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
