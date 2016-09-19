using FizzWare.NBuilder;
using stratMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stratMVC.Controllers
{
    public class CustomerProfileController : Controller
    {
        //
        // GET: /CustomerProfile/
        public ActionResult Index()
        {
            var profiles = Builder<CustomerProfile>.CreateListOfSize(10).Build();
            return View(profiles);
        }

        //
        // GET: /CustomerProfile/Details/5
        public ActionResult Details(int id)
        {
            var model = new CustomerProfile();
            model.id = id;
            model.Name = "Fai";
            model.Lastname = "Nounnapasri";
            return View(model);
        }

        //
        // GET: /CustomerProfile/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CustomerProfile/Create
        [HttpPost]
        public ActionResult Create(CustomerProfile collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CustomerProfile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CustomerProfile/Edit/5
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
        // GET: /CustomerProfile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CustomerProfile/Delete/5
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
    }
}
