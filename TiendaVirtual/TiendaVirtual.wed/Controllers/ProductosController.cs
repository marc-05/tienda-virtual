using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaVirtual.wed.Models;

namespace TiendaVirtual.wed.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            ProductoModel producto1 = new ProductoModel
            {
                Id = 1,
                Descripcion = "Coffee Organico"
            };

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Coffee Latte";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Coffee Capuchino";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return View(listadeproductos);
        }
    }
}