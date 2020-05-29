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
    public class ContactController : Controller
    {
        private ContactService db = new ContactService();
        // GET: Contact
        public ActionResult Index()
        {
            var list = db.AllList();
            return View(list);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost,ValidateInput(false)]
        public ActionResult Create(Contact contact)
        {
            if(ModelState.IsValid)
            {
                db.Create(contact);
                return RedirectToAction("Index","Home");
            }
            return View(contact);
        }
        public ActionResult Delete(int id)
        {
            var contact = db.AllList().FirstOrDefault(x => x.Id == id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfimed(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index","Home");
        }
    }
}