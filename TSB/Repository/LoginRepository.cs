using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.DatabaseContext;
using TSB.Entites;
namespace TSB.Repository
{
    public class LoginRepository
    {
        private TsbDbContext db = new TsbDbContext();
        public Admin GetById(string UserName)
        {
            return db.Admins.SingleOrDefault(a => a.UserName == UserName);
        }
        public bool Login (string UserName , string Password)
        {
            var check = db.Admins.Count(x => x.UserName == UserName && x.PassWord == Password);
            if(check >0)
            {
                return true;
            }
            return false;
        }
    }
}