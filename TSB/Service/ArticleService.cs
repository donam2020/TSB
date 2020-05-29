using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Repository;
using TSB.Entites;
namespace TSB.Service
{
    public class ArticleService
    {
        private ArticleRepository db = new ArticleRepository();
        public List<Article> AllList()
        {
            return db.AllList();
        }
        public Article Getone(int id)
        {
            return db.Getone(id);
        }
        public bool Create(Article article)
        {
            return db.Create(article);
        }
        public Article Update(Article article)
        {
            return db.Update(article);
        }
        public Article Delete(int id)
        {
            return db.Delete(id);
        }
    }
}