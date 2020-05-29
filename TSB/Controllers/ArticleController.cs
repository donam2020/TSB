using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSB.ViewModel;
using TSB.Service;
using TSB.Entites;
using TSB.DatabaseContext;
using PagedList;

namespace TSB.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private ArticleService service = new ArticleService();
        private TsbDbContext db = new TsbDbContext();
        private CategoryService cate = new CategoryService();
        // GET: Article
        public ActionResult Index(int? page, int CatId = 0)
        {
            var PageNumber = page ?? 1;
            const int pageSize = 5;
            var article = db.Articles.Where(x => x.CountView >= 0);
            if (CatId > 0)
            {
                article = article.Where(x => x.CategoryId == CatId);
            }
            ViewBag.category = new SelectList(db.Categories.Where(x => x.ParentId == null).OrderBy(x => x.Order), "Id", "Name"); ;
            ViewBag.catId = CatId;
            return View(article.OrderByDescending(x => x.CreateDate).ToPagedList(PageNumber, pageSize));
        }
        public ActionResult Create()
        {
            var model = new ActicleViewModel()
            {
                ParentCategory = db.Categories.Where(x => x.ParentId == null)
            };
            return View(model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(ActicleViewModel model, FormCollection fc)

        {
            model.ParentCategory = cate.AllList();
            if (ModelState.IsValid)
            {
              
                model.Article.CreateBy = User.Identity.Name;
                var u = service.Create(model.Article);
                return RedirectToAction("Index");
            }

            model.ParentCategory = db.Categories.Where(c => c.ParentId == 0);

            return View(model);
        }
        public ActionResult Update(int id)
        {
            var article = db.Articles.FirstOrDefault(x => x.Id == id);
            if (article == null)
            {
                return HttpNotFound();
            }
            var model = new ActicleViewModel
            {
                Article = article,
                ParentCategory = db.Categories.Where(x => x.ParentId == null)
            };
            return View(model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Update(int id, ActicleViewModel model)
        {
            var article = db.Articles.FirstOrDefault(x => x.Id == id);
            if (article != null)
            {

                if (ModelState.IsValid)
                {
                    service.Update(model.Article);
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var category = service.AllList().FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfimed(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var details = service.Getone(id);
            return View(details);
        }
    }
}