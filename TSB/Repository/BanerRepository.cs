using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.DatabaseContext;
using TSB.Entites;
using PagedList;
namespace TSB.Repository
{
    public class BanerRepository
    {
        private TsbDbContext db = new TsbDbContext();
        public List<Baner> AllList()
        {
            return db.Baners.ToList();
        }
        public Baner Getone(int id)
        {
            return db.Baners.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable <Baner> ListAllPaging(int page,int pageSize)
        {
            return db.Baners.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        }
        public bool Create(Baner baner)
        {
            baner.CreateDate = DateTime.Now;
            db.Baners.Add(baner);
            var res = db.SaveChanges();
            return res > 0;
        }
        public Baner Update(Baner baner)
        {
            var update = db.Baners.FirstOrDefault(x => x.Id == baner.Id);
            if (update != null)
            {
                update.Image = baner.Image;
                update.Name = baner.Name;
                update.Order = baner.Order;
                update.Positon = baner.Positon;
                update.Status = baner.Status;
                update.Url = baner.Url;
                var res = db.SaveChanges();
                return res > 0 ? update : null;
            }
            return null;
        }
        public Baner Delete(int id)
        {
            var delete = db.Baners.FirstOrDefault(c => c.Id == id);
            if(delete != null)
            {
                db.Baners.Remove(delete);
                var res = db.SaveChanges();
                return res > 0 ? delete : null;
            }
            return null;
        }
    }
}