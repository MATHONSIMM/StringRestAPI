using StringRestAPI.Data;
using StringRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StringRestAPI.Controllers
{
    public class StringsController : Controller
    {
        StringsDbContext stringsDbContext = new StringsDbContext();
        // GET: Strings
        public IEnumerable<Strings>Get()
        {
            return stringsDbContext.Strings;
        }

        // GET: Strings/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Strings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Strings/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: Strings/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Strings/Edit/5
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

        // GET: Strings/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Strings/Delete/5
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
