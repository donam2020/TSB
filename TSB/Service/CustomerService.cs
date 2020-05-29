using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Repository;
using TSB.Entites;
namespace TSB.Service
{
    public class CustomerService
    {
        private CustomerRepository customer = new CustomerRepository();
        public List<Customer> AllList()
        {
            return customer.AllList();
        }
        public Customer Getone(int id)
        {
            return customer.Getone(id);
        }
        public bool Create(Customer custome)
        {
            return customer.Create(custome);
        }
        public Customer Delete(int id)
        {
            return customer.Delete(id);
        }
    }
}