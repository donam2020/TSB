using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.DatabaseContext;
using TSB.Entites;
using PagedList;
namespace TSB.Repository
{
    public class ArticleRepository
    {
        private TsbDbContext db = new TsbDbContext();
        public List<Article> AllList()
        {
            return db.Articles.ToList();
        }
        public Article Getone(int id)
        {
            return db.Articles.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<Category> ListAllPaging(int page,int pageSize)
        {
            return db.Categories.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        }
        public bool Create(Article article)
        {
            article.CreateDate = DateTime.Now;
            db.Articles.Add(article);
            var res = db.SaveChanges();
            return res > 0;
        }
        public Article Update(Article article)
        {
            var update = db.Articles.FirstOrDefault(x => x.Id == article.Id);
            if (update != null)
            {
                update.Image = article.Image;
                update.Name = article.Name;
                update.ShowHome = article.ShowHome;
                update.Status = article.Status;
                update.Sumary = article.Sumary;
                update.Title = article.Title;
                update.Content = article.Content;
                update.CategoryId = article.CategoryId;               
                var res = db.SaveChanges();
                return res > 0 ? update : null;
            }
            return null;
        }
        public Article Delete(int id)
        {
            var delete = db.Articles.FirstOrDefault(x => x.Id == id);
            if(delete != null)
            {
                db.Articles.Remove(delete);
                 var res = db.SaveChanges();
                return res > 0 ? delete : null; 
            }
            return null;
        }
    }
}