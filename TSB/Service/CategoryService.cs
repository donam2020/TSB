using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Entites;
using TSB.Repository;

namespace TSB.Service
{
    public class CategoryService
    {
        private CategoryRepository repo = new CategoryRepository();
        public List<Category> AllList()
        {
            return repo.AllList();
        }
        public Category Getone(int id)
        {
            return repo.Getone(id);
        }
        public bool Create (Category cate)
        {
            return repo.Create(cate);
        }
        public Category Update(Category cate)
        {
            return repo.Update(cate);
        }
        public Category Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}