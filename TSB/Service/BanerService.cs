using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Repository;
using TSB.Entites;
namespace TSB.Service
{
    public class BanerService
    {
        private BanerRepository db = new BanerRepository();
        public List<Baner> AllList()
        {
            return db.AllList();
        }
        public Baner Getone(int id)
        {
            return db.Getone(id);
        }
        public bool Create(Baner baner)
        {
            return db.Create(baner);
        }
        public Baner Update(Baner baner)
        {
            return db.Update(baner);
        }
        public Baner Delete(int id)
        {
            return db.Delete(id);
        }
    }
}