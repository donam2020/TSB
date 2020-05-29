using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSB.Entites;
using TSB.Service;
namespace TSB.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        // GET: Category
        private CategoryService db = new CategoryService();
        public ActionResult Index()
        {
            var model = new CategoryC { ParentId = db.AllList().Where(x => x.ParentId == null).OrderBy(x => x.Order) };
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.ParentId = new SelectList(db.AllList().Where(x => x.ParentId == null).OrderBy(x => x.Order), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Create(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public ActionResult Update(int id)
        {
            var category = db.AllList().FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParentId = new SelectList(db.AllList().Where(x => x.ParentId == null).OrderBy(x => x.Order), "Id", "Name", category.ParentId);
            return View(category);
        }
        [HttpPost]
        public ActionResult Update(int id, Category cat, FormCollection fc)
        {
            cat.Id = id;
            if (ModelState.IsValid)
            {
                db.Update(cat);
                return RedirectToAction("Index");
            }
            ViewBag.ParentId = new SelectList(db.AllList().Where(x => x.ParentId == null).OrderBy(x => x.Order), "Id", "Name");
            return View(cat);
        }
        public ActionResult Delete(int id)
        {
            var category = db.AllList().FirstOrDefault(x => x.Id == id);
            if(category == null)
            {
               return HttpNotFound();
            }
            return View(category);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfimed(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}