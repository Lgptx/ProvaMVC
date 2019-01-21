using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Prova8.DAL;
using Prova8.Models;

namespace Prova8.Controllers
{
    public class ContatoUsuariosController : Controller
    {
        private EFContext db = new EFContext();

        // GET: ContatoUsuarios
        public ActionResult Index()
        {
            var contatoUsuario = db.ContatoUsuario.Include(c => c.Email);
            return View(contatoUsuario.ToList());
        }

        // GET: ContatoUsuarios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContatoUsuario contatoUsuario = db.ContatoUsuario.Find(id);
            if (contatoUsuario == null)
            {
                return HttpNotFound();
            }
            return View(contatoUsuario);
        }

        // GET: ContatoUsuarios/Create
        public ActionResult Create()
        {
            ViewBag.EmailID = new SelectList(db.Usuario, "EmailID", "Nome");
            return View();
        }

        // POST: ContatoUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NomeContatoID,EmailContato,TelefoneContato,EmailID")] ContatoUsuario contatoUsuario)
        {
            if (ModelState.IsValid)
            {
                db.ContatoUsuario.Add(contatoUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmailID = new SelectList(db.Usuario, "EmailID", "Nome", contatoUsuario.EmailID);
            return View(contatoUsuario);
        }

        // GET: ContatoUsuarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContatoUsuario contatoUsuario = db.ContatoUsuario.Find(id);
            if (contatoUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmailID = new SelectList(db.Usuario, "EmailID", "Nome", contatoUsuario.EmailID);
            return View(contatoUsuario);
        }

        // POST: ContatoUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NomeContatoID,EmailContato,TelefoneContato,EmailID")] ContatoUsuario contatoUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contatoUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmailID = new SelectList(db.Usuario, "EmailID", "Nome", contatoUsuario.EmailID);
            return View(contatoUsuario);
        }

        // GET: ContatoUsuarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContatoUsuario contatoUsuario = db.ContatoUsuario.Find(id);
            if (contatoUsuario == null)
            {
                return HttpNotFound();
            }
            return View(contatoUsuario);
        }

        // POST: ContatoUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ContatoUsuario contatoUsuario = db.ContatoUsuario.Find(id);
            db.ContatoUsuario.Remove(contatoUsuario);
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
