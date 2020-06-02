using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Entites;
namespace TSB.ViewModel
{
    public class HomeViewModel
    {
        public Config Configs { get; set; }
        public IEnumerable<Baner> Baners { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable <Category> CategoryHome { get; set; }
        public IEnumerable <Contact> Contacts { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
    public class DetailsCategory
    {
        public Category Category { get; set; }
        public IEnumerable <Baner> Baners { get; set; }
        public IEnumerable <Article> Articles { get; set; }
        public IEnumerable<Category> CategoryHome { get; set; }

    }
    public class aboutfotter
    {
        public IEnumerable<Category> Categories { get; set; }
        public Config Config { get; set; }
        public IEnumerable <Baner> Baners { get; set; }
        public IEnumerable<Article> Articles { get; set; }
    }

}