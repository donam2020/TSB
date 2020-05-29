using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Entites;
using TSB.DatabaseContext;
namespace TSB.Repository
{
   
    public class UpdateConfig
    {
        private TsbDbContext db = new TsbDbContext();
        public List<Config> AllList ()
        {
            return db.Configs.ToList();
        }
        public Config Getone (int id)
        {
            return db.Configs.FirstOrDefault(x => x.Id == id);
        }
        public bool Create(Config config)
        {
            db.Configs.Add(config);
            var res = db.SaveChanges();
            return res > 0;
        }
        public Config Update (Config config)
        {
            var update = db.Configs.FirstOrDefault(x => x.Id == config.Id);
            if(update != null)
            {
                update.ImageAbout = config.ImageAbout;
                update.ImageCategory = config.ImageCategory;
                update.InfoAbout = config.InfoAbout;
                update.LinkFacebook = config.LinkFacebook;
                update.LinkGoogle = config.LinkGoogle;
                update.LinkTwichter = config.LinkTwichter;
                update.LinkYoutube = config.LinkYoutube;
                update.Phone = config.Phone;
                update.TitleHome = config.TitleHome;
                update.Name = config.Name;
                update.Email = config.Email;
                update.Description = config.Description;
                update.CategoryAbout = config.CategoryAbout;
                update.Addres = config.Addres;
                var res = db.SaveChanges();
                return res > 0 ? update : null;

            }
            return null;
        }
        public Config Delete (int id)
        {
            var delete = db.Configs.FirstOrDefault(x => x.Id == id);
            if(delete != null)
            {
                db.Configs.Remove(delete);
                var res = db.SaveChanges();
                return res > 0 ? delete : null;
            }
            return null;
        }
    }
}