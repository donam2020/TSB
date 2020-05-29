using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSB.DatabaseContext;
using TSB.Entites;
using TSB.ViewModel;
namespace TSB.Controllers
{
    public class HomeController : Controller
    {
        private TsbDbContext db = new TsbDbContext();
        public ActionResult Index()
        {
            var category = db.Categories.Where(x => x.ShowHome == true && x.Status == true).ToList();
            var model = new HomeViewModel
            {
                Configs = db.Configs,
                Baners = db.Baners.OrderByDescending(x=>x.CreateDate),
                Customers = db.Customers,
                CategoryHome = category,
                Articles = db.Articles.OrderByDescending(x=>x.CreateDate)
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public PartialViewResult Header()
        {
            var catagory = db.Categories;
            var model = new HomeViewModel
            {
                Configs= db.Configs,
                CategoryHome = catagory,
                Baners = db.Baners.OrderByDescending(x=>x.CreateDate)
            };
            return PartialView(model);
        }
        public PartialViewResult Footer()
        {
            var category = db.Categories.ToList(); ;
            var config = db.Configs.ToList();
            var model = new aboutfotter
            {
                Categories = category,
                Baners = db.Baners.OrderByDescending(x=>x.CreateDate),
                Config = config
            };
            return PartialView(model);
        }
        public PartialViewResult Baner()
        {
            return PartialView();
        }
    }
}