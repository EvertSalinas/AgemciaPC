using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agemcia.Models;
using Agemcia.ViewModels;

namespace Agemcia.Controllers
{
    public class ValesController : Controller
    {
        private ApplicationDbContext _context;

        public ValesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult NuevoVale()
        {
            var productos = _context.Productos.ToList();
            var viewModel = new ValeFormViewModel
            {
                Productos = productos
            };

            return View(viewModel);
        }

        /*
        [HttpPost]
        public ActionResult GuardarVale(Vale vale)
        {
            if (vale.id == 0)
            {
                _context.Vales.Add(vale);
            }
            else
            {
                var reporteInDb = _context.Vales.Single(p => p.id == vale.id);

                reporteInDb.numero = vale.numero;
            }

            _context.SaveChanges();

            return RedirectToAction("Lista", "Reportes");
        }*/
    }
}