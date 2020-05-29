using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TSB.Entites;
namespace TSB.DatabaseContext
{
    public class TsbDbContext : DbContext
    {
        public TsbDbContext() : base("name = NewsConnectionString") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Baner> Baners { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Config> Configs { get; set; }
       
       
    }
}