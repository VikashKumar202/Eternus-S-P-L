using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIFinalFianl.Controllers
{
    public class EmployeeFrotController : Controller
    {
        //
        // GET: /EmployeeFrot/
        public ActionResult AddRecord()
        {
            return View();
        }

        //
        // GET: /EmployeeFrot/Details/5
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /EmployeeFrot/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EmployeeFrot/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /EmployeeFrot/Edit/5
        public ActionResult Edit(int id)
        {
            Session["data"] = id;
            return View();
        }

        //
        // POST: /EmployeeFrot/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /EmployeeFrot/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        //
        // POST: /EmployeeFrot/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult MainView()
        {
            return View();
        }
    }
}
