using New_Crud_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New_Crud_MVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDb db = new ApplicationDb();
        public ActionResult Delete(int id)
        {
            var n = db.employees.Where(model => model.Id == id).FirstOrDefault();
            db.Entry(n).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var val = db.employees.Where(model => model.Id == id).FirstOrDefault();
            return View(val);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("index");

        }
        public ActionResult Index()
        {
            var res = db.employees.ToList();
            return View(res);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
           
               var val= db.employees.Add(emp);
               db.SaveChanges();
               return RedirectToAction("Index");
            
          
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}