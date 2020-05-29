using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Entites;
using TSB.DatabaseContext;
namespace TSB.Repository
{
    public class CategoryRepository
    {
        private TsbDbContext db = new TsbDbContext();
        public List<Category> AllList()
        {
            return db.Categories.ToList();
        }
        public Category Getone(int id)
        {
            return db.Categories.FirstOrDefault(x => x.Id == id);
        }
        public bool Create( Category cate)
        {
            cate.CreateDate = DateTime.Now;
            db.Categories.Add(cate);
            var res = db.SaveChanges();
            return res > 0;
        }
        public Category Update(Category cate)
        {
            var update = db.Categories.FirstOrDefault(x => x.Id == cate.Id);
            if(update != null)
            {
                update.Image = cate.Image;
                update.Name = cate.Name;
                update.Order = cate.Order;
                update.ParentId = cate.ParentId;
                update.ShowHome = cate.ShowHome;
                update.Status = cate.Status;
                update.TypeShow = cate.TypeShow;
                var res = db.SaveChanges();
                return res > 0 ? update : null;
            }
            return null;

        }
        public Category Delete (int id)
        {
            var delete = db.Categories.FirstOrDefault(x => x.Id == id);
            if(delete != null)
            {
                db.Categories.Remove(delete);
                var res = db.SaveChanges();
                return res > 0 ? delete : null;
            }
            return null;
        }
    }
}