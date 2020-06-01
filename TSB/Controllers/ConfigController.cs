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
    public class ConfigController : Controller
    {
        private ConfigService _config = new ConfigService();
        // GET: Config
        public ActionResult Index()
        {

            return View(_config.AllList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost,ValidateInput(false)]
        public ActionResult Create(Config config)
        {
            if (ModelState.IsValid)
            {
                config.CreateDate = DateTime.Now;
                config.CreateBy = User.Identity.Name;
                _config.Create(config);
                return RedirectToAction("Index");
            }
            return View(config);
        }
        public ActionResult Update(int id)
        {
            var update = _config.AllList().FirstOrDefault(x => x.Id == id);
            if (update == null)
            {
                return HttpNotFound();
            }

            return View(update);
        }
        [HttpPost,ValidateInput(false)]
        public ActionResult Update(int id, Config config)
        {
            config.Id = id;
            if (ModelState.IsValid)
            {
                _config.Update(config);
                return RedirectToAction("Index");
            }
            return View(config);
        }

        public ActionResult Details(int id)
        {
            var details = _config.Getone(id);
            return View(details);       
        }
    }
}