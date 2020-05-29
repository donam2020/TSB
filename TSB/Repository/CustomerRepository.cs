using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.DatabaseContext;
using TSB.Entites;
namespace TSB.Repository
{
    public class CustomerRepository
    {
        private TsbDbContext db = new TsbDbContext();
        public List<Customer> AllList ()
        {
            return db.Customers.ToList();
        }
        public Customer Getone(int id)
        {
            return db.Customers.FirstOrDefault(x => x.Id == id);
        }
        public bool Create(Customer customer)
        {
            db.Customers.Add(customer);
            var res = db.SaveChanges();
            return res > 0;
        }
        public Customer Delete(int id)
        {
            var delete = db.Customers.FirstOrDefault(x => x.Id == id);
            if(delete !=null)
            {
                db.Customers.Remove(delete);
                var res = db.SaveChanges();
                return res > 0 ? delete : null;
            }
            return null;
        }
    }
}