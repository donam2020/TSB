using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSB.Entites;
using TSB.Repository;
namespace TSB.Service
{
    public class ConfigService
    {
        private UpdateConfig update = new UpdateConfig();
        public List<Config>AllList()
        {
            return update.AllList();
        }
        public Config Getone(int id)
        {
            return update.Getone(id);
        }
        public bool Create(Config config)
        {
            return update.Create(config);
        }
        public Config Update(Config config)
        {
            return update.Update(config);
        }
        public Config Delete(int id)
        {
            return update.Delete(id);
        }
    }
}