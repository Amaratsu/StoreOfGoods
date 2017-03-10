using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;

namespace WebUI.Controllers
{
    [Authorize]
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
        public ActionResult Edit(Product product, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    product.ImageMimeType = image.ContentType;
                    product.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(product.ImageData, 0, image.ContentLength);
                }

                db.Entry(product).State = product.ProductId == 0 ? EntityState.Added : EntityState.Modified;

                db.SaveChanges();
                TempData["message"] = $"Изменения в товаре \"{product.Name}\" были сохранены";
                return Redirect("~/");
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
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMimeType = product.ImageMimeType;
                }
            }
            db.SaveChanges();
        }

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }

        [HttpGet]
        public ActionResult Delete(int? productId)
        {
            if (productId == null)
            {
                return HttpNotFound();
            }
            Product product = db.Products.Find(productId);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? productId)
        {
            if (productId == null)
            {
                return HttpNotFound();
            }
            Product product = db.Products.Find(productId);
            if (product == null)
            {
                return HttpNotFound();
            }
            db.Products.Remove(product);
            db.SaveChanges();
            TempData["message"] = $"Товар \"{product.Name}\" был удален";
            return RedirectToAction("Index");
        }
    }
}