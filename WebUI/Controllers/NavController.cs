using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {
        private EfDbContext db = new EfDbContext();

        public PartialViewResult Menu( string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = db.Products
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(c => c);
            return PartialView(categories);
        }
    }
}