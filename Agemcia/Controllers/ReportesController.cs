using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agemcia.Models;
using Agemcia.ViewModels;

namespace Agemcia.Controllers
{
    public class ReportesController : Controller
    {
        private ApplicationDbContext _context;

        public ReportesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Lista()
        {
            var reportes = _context.Reportes.ToList();
            return View(reportes);
        }

        public ActionResult NuevoReporte()
        {
            var viewModel = new ReporteFormViewModel();

            return View("NuevoReporte", viewModel);
        }

        public ActionResult Detalle(int id)
        {
            var reporte = _context.Reportes.SingleOrDefault(p => p.id == id);

            return View(reporte);
        }

        [HttpPost]
        public ActionResult GuardarReporte(Reporte reporte)
        {
            if (reporte.id == 0)
            {
                _context.Reportes.Add(reporte);
            }
            else
            {
                var reporteInDb = _context.Reportes.Single(p => p.id == reporte.id);

                reporteInDb.fecha = reporte.fecha;
            }

            _context.SaveChanges();

            return RedirectToAction("Lista", "Reportes");
        }
    }
}