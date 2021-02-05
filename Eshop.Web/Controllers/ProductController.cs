using Eshop.Entities;
using Eshop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productService = new ProductsService();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProductTable(string search)
        {
            var products = productService.GetProducts();
            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productService.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var product = productService.GetProduct(ID);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int productID)
        {
            var category = productService.GetProduct(productID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            product = productService.GetProduct(product.ID);
            productService.GetProduct(product.ID);
            return RedirectToAction("Index");
        }
    }
}