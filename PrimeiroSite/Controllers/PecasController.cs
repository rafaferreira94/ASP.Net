using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrimeiroSite.Models;

namespace PrimeiroSite.Controllers
{
    public class PecasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Universidade
        public ActionResult Index()
        {
            return View(db.Universidades.ToList());
        }

        // GET: Universidade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pecas universidade = db.Universidades.Find(id);
            if (universidade == null)
            {
                return HttpNotFound();
            }
            return View(universidade);
        }

        // GET: Universidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Universidade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Sigla")] Pecas universidade)
        {
            if (ModelState.IsValid)
            {
                db.Universidades.Add(universidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(universidade);
        }

        // GET: Universidade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pecas universidade = db.Universidades.Find(id);
            if (universidade == null)
            {
                return HttpNotFound();
            }
            return View(universidade);
        }

        // POST: Universidade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Sigla")] Pecas universidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(universidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(universidade);
        }

        // GET: Universidade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pecas universidade = db.Universidades.Find(id);
            if (universidade == null)
            {
                return HttpNotFound();
            }
            return View(universidade);
        }

        // POST: Universidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pecas universidade = db.Universidades.Find(id);
            db.Universidades.Remove(universidade);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
