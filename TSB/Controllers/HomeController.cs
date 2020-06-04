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
                Configs = db.Configs.FirstOrDefault(),
                Baners = db.Baners.OrderByDescending(x => x.CreateDate),
                Customers = db.Customers,
                CategoryHome = category,
                Articles = db.Articles.OrderByDescending(x => x.CreateDate)
            };
            return View(model);
        }


        public PartialViewResult Header()
        {
            var catagory = db.Categories;
            var model = new HomeViewModel
            {
                Configs = db.Configs.FirstOrDefault(),
                CategoryHome = catagory,
                Baners = db.Baners.OrderByDescending(x => x.CreateDate)
            };
            return PartialView(model);
        }
       

        public ActionResult Introl()
        {
            ViewBag.messenger = "Giới thiệu công ty";
            var model = new HomeViewModel
            {
                CategoryHome = db.Categories.Where(x => x.ShowHome == true && x.Status == true).ToList()
            };
            return View(model);
        }
        public ActionResult History()
        {
            ViewBag.messenger = "Lịch sử phát triển";

            var model = new HomeViewModel
            {
                CategoryHome = db.Categories.Where(x => x.ShowHome == true && x.Status == true).ToList()
            };
            return View(model);

        }
        public ActionResult Diagram()
        {

            ViewBag.messenger = "Doanh thu hàng năm và sơ đồ tổ chức";
            var model = new HomeViewModel
            {
                CategoryHome = db.Categories.Where(x => x.ShowHome == true && x.Status == true).ToList()
            };
            return View(model);
        }
        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult category(int catid)
        {
            ViewBag.messenger = "Giới thiệu";
            var category = db.Categories.Find(catid);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            //var article = db.Articles.Where(x => x.CategoryId == catid).OrderBy(x => x.CreateDate).ToList();
            var model = new DetailsCategory
            { 
                Baners = db.Baners.ToList(),
                Category = category,
                Articles = db.Articles.OrderByDescending(x=>x.CreateDate),
                CategoryHome = db.Categories.ToList()
                
            };
            return View(model);
        }
        public PartialViewResult Footer()
        {
            var category = db.Categories.ToList();
            var model = new aboutfotter
            {
                Articles = db.Articles.ToList(),
                Categories = category,
                Baners = db.Baners.OrderByDescending(x => x.CreateDate),
                Config = db.Configs.FirstOrDefault()
            };
            return PartialView(model);
        }
        public ActionResult Details(int id)
        {
            var article = db.Articles.Find(id);         
            //var ar = db.Articles.Where(x => x.CategoryId == id);
            var model = new HomeViewModel
            {
                Article = article,
                CategoryHome = db.Categories.ToList(),
               Articles = db.Articles.ToList()
            };
            return View(model);
        }
    }
}