using ProvaProd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaProd.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Index()
        {
            return View(new List<Contatos>());
        }

        // GET: Contato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contato/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Contatos objContato = new Contatos();
                objContato.Nome = collection["Nome"].ToString();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contato/Edit/5
        public ActionResult Edit(int id)
        {
            Contatos objContato = new Contatos();
            

            return View(objContato);
        }

        // POST: Contato/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Contatos objContato = new Contatos();
                objContato.Nome = collection["Nome"].ToString();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contato/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        
    }
}
