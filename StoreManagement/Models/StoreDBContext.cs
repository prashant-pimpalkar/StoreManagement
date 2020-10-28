using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StoreManagement.Models
{
    public class StoreDBContext :DbContext
    {
        public StoreDBContext():base("name = conn")
        {
            Database.SetInitializer<StoreDBContext>(null);
        }
        public DbSet<VilageInfo> VilageInfos { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
    }

}