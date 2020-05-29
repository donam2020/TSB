using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSB.Service;
using TSB.Entites;
using TSB.Repository;

namespace TSB.Controllers
{
    [Authorize]
    public class BanerController : Controller
    {
        // GET: Baner
        private BanerService db = new BanerService();
        private BanerRepository ban = new BanerRepository();
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            var model = ban.ListAllPaging(page, pageSize);
            return View(model);
        }
        public ActionResult Create()
        {

            return View(new Baner());
        }
        [HttpPost]
        public ActionResult Create(Baner baner)
        {
            if (ModelState.IsValid)
            {
                db.Create(baner);
                return RedirectToAction("Index");
            }
            return View(baner);

        }
        public ActionResult Update(int id)
        {
            var baner = db.AllList().FirstOrDefault(x => x.Id == id);
            if (baner == null)
            {
                return HttpNotFound();
            }
            return View(baner);
        }
        [HttpPost]
        public ActionResult Update(int id, Baner baner, FormCollection fc)
        {
            baner.Id = id;
            if (ModelState.IsValid)
            {
                db.Update(baner);
                return RedirectToAction("Index");
            }
            return View(baner);
        }
        public ActionResult Delete(int id)
        {
            var baner = db.AllList().FirstOrDefault(x => x.Id == id);
            if (baner == null)
            {
                return HttpNotFound();
            }
            return View(baner);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfimed(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}