using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpGuitarBugs.Controllers
{
    public class GuitarController : Controller
    {
        // GET: Guitar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Guitar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Guitar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guitar/Create
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

        // GET: Guitar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Guitar/Edit/5
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

        // GET: Guitar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Guitar/Delete/5
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
