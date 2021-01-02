using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class CatController : Controller
    {
        // GET: Cat
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("cat/{catName}")]
        [Route("action")]
        public string Cat(string catName)
        {
            switch (catName.ToLower())
            {
              case "bill":
                return "Meow";

              case "steve":
                    return "Purr";

                default:
                    break;
            }
            return string.Empty;
        }        

        // GET: Cat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cat/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cat/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cat/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}