using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agemcia.Models;
using System.Text;
using Agemcia.ViewModels;

namespace Agemcia.Controllers
{
    public class ProductosController : Controller
    {
        private ApplicationDbContext _context;

        public ProductosController()
        {
            _context = new ApplicationDbContext();   
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Lista(string searchString)
        {
            var productos = _context.Productos.ToList();
            var productosAux = new List<Producto>();
            if (!String.IsNullOrEmpty(searchString))
            {
                foreach (var m in productos)
                {
                    if (m.nombre.ToUpper().Contains(searchString.ToUpper()))
                    {
                        productosAux.Add(m);
                    }
                }
            }
            else
                productosAux = productos;
            searchString = null;
            return View(productosAux);
        }

        public ActionResult AgregarProducto()
        {
            var viewModel = new ProductoFormViewModel();

            return View("AgregarProducto", viewModel);
        }

        [HttpPost]
        public ActionResult Guardar(Producto producto)
        {
            
            if(!ModelState.IsValid)
            {
                var viewModel = new ProductoFormViewModel
                {
                    Producto = producto
                };

                return View("AgregarProducto", viewModel);
            }
            
            if (producto.id == 0)
            {
                _context.Productos.Add(producto);
            }
            else
            {
                var productoInDb = _context.Productos.Single(p => p.id == producto.id);

                productoInDb.nombre = producto.nombre;
                productoInDb.precio = producto.precio;
            }

           _context.SaveChanges();

            return RedirectToAction("Lista", "Productos");
        }


        public ActionResult Editar(int id)
        {
            var producto = _context.Productos.SingleOrDefault(p => p.id == id);
            if (producto == null)
                return HttpNotFound();

            var viewModel = new ProductoFormViewModel()
            {
                Producto = producto
            };

            return View("AgregarProducto", viewModel);
        }
        /*
        public ActionResult Borrar(int id)
        {
            var producto = _context.Productos.SingleOrDefault(p => p.id == id);
            if (producto == null)
                return HttpNotFound();

            _context.Productos.Remove(producto);
            _context.SaveChanges();

            return View("Lista");
        }
        */
    }
}