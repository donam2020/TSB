using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.DatabaseContext;
using TSB.Entites;
namespace TSB.ViewModel
{
    public class ActicleViewModel
    {
        private TsbDbContext db = new TsbDbContext();
        public Article Article { get; set; }
        public IEnumerable<Category> ParentCategory { get; set; }
        public IEnumerable<Category> ChildsCateegory(int ParentId)
        {
            return db.Categories.Where(x => x.ParentId == ParentId);
        }
    }
}