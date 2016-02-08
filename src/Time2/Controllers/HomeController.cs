using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Time2.Model;

namespace Time2.Controllers
{
    public class HomeController : Controller
    {
        ModelContext db;
        public HomeController(ModelContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            DateTime date = DateTime.Now;
            ViewBag.date = date;
            return View();
        }

        [HttpPost]
        public IActionResult Index(WriteOff writeoff)
        {
            db.WriteOffs.Add(writeoff);
            // сохраняем в бд все изменения
            db.SaveChanges();
            DateTime resultdate = DateTime.Now;
            ViewBag.resultdate = resultdate;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
