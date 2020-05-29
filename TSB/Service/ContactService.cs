using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Repository;
using TSB.Entites;
namespace TSB.Service
{
    public class ContactService
    {
        private ContactRepository db = new ContactRepository();
       public List<Contact> AllList()
        {
            return db.AllList();
        }
        public Contact Getone(int id)
        {
            return db.Getone(id);
        }
        public bool Create (Contact contact)
        {
            return db.Create(contact);
        }
        public Contact Update(Contact contact)
        {
            return db.Update(contact);
        }
        public Contact Delete(int id)
        {
            return db.Delete(id);
        }
    }
}