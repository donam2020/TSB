using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSB.Service;
using TSB.Entites;
namespace TSB.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private CustomerService _customer = new CustomerService();
        // GET: Customer
        public ActionResult Index()
        {
            return View(_customer.AllList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if(ModelState.IsValid)
            {
                _customer.Create(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var details = _customer.Getone(id);
            return View(details);
        }
        public ActionResult Delete(int id)
        {
            var delete = _customer.Getone(id);
            if(delete == null)
            {
                return HttpNotFound();
            }
            return View(delete);
        }
        [HttpPost ,ActionName("Delete")]
        public ActionResult DeleteName(int id)
        {
            _customer.Delete(id);
            return RedirectToAction("Index");
        }
    }
}