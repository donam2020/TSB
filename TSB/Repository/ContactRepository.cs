using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.DatabaseContext;
using TSB.Entites;

namespace TSB.Repository
{
    public class ContactRepository
    {
        private TsbDbContext db = new TsbDbContext();
        public List<Contact> AllList()
        {
            return db.Contacts.ToList();
        }
        public Contact Getone(int id)
        {
            return db.Contacts.FirstOrDefault(x => x.Id == id);
        }
        public bool Create(Contact contact)
        {
            contact.Status = true;
            db.Contacts.Add(contact);
            var res = db.SaveChanges();
            return res > 0;
        }
        public Contact Update(Contact contact)
        {
            var update = db.Contacts.FirstOrDefault(x => x.Id == contact.Id);
            if(update != null)
            {
                update.CompanyName = contact.CompanyName;
                update.Name = contact.Name;
                update.Phone = contact.Phone;
                update.Status = contact.Status;
                update.Addres = contact.Addres;
                update.Content = contact.Content;
                update.Email = contact.Email;
                var res = db.SaveChanges();
                return res > 0 ? update : null;
            }
            return null;
        }
        public Contact Delete(int id)
        {
            var delete = db.Contacts.FirstOrDefault(x => x.Id == id);
            if(delete !=null)
            {
                db.Contacts.Remove(delete);
                var res = db.SaveChanges();
                return res > 0 ? delete : null;
            }
            return null;
        }
    }
}