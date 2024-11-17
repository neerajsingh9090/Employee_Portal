using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Emp.Models;
using System.Data.Entity;
namespace Project_Emp.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public RanaContext db = new RanaContext();




        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
              
                if (model.Username == "neeraj" && model.Password == "123")
                {
                
                    Session["Username"] = model.Username;


                    return RedirectToAction("Userview", "Employee");
                }
                ModelState.AddModelError("", "Invalid login attempt.");
            }
            return View(model);
        }




        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Admin(Admin model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "Rana" && model.Password == "123")
                {
                   
                    Session["Username"] = model.Username;

                   
                    return RedirectToAction("Index", "Employee");
                }
                ModelState.AddModelError("", "Invalid login attempt.");
            }
            return View(model);
        }







        [HttpGet]
        public ActionResult Userview()
        {

            var data = db.employee.ToList();
            return View(data);
        
        }






        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                db.employee.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }









        }
        [HttpGet]
        public ActionResult Employee_List()
        {
            var data = db.employee.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Details(int id = 0)
        {
            Employee employee = db.employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpGet]
        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            else
            {
                db.employee.Remove(employee);
                db.SaveChanges();
                return RedirectToAction("Employee_List");
            }



        }

[HttpGet]
public ActionResult Edit(int id)
{
    var employee = db.employee.Find(id);
    if (employee == null)
    {
        return HttpNotFound();
    }
    return View(employee);
}

[HttpPost]
public ActionResult Edit(Employee emp)
{
    if (ModelState.IsValid)
    {
        db.Entry(emp).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Employee_List");
    }
    return View(emp);
}









        }
    }

