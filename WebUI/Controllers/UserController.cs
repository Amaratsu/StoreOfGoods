using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        private EfDbContext db = new EfDbContext();

        public ViewResult Index()
        {
            return View(db.Products);
        }

        public ViewResult Edit(int productId)
        {
            Product product = db.Products
                .FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                TempData["message"] = $"Изменения в товаре \"{product.Name}\" были сохранены";
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }

        public void Save(Product product)
        {
            if (product.ProductId == 0)
            {
                db.Products.Add(product);
            }
            else
            {
                Product dbEntry = db.Products.Find(product.ProductId);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            db.SaveChanges();
        }
    }
}