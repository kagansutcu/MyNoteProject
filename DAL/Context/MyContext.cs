using MAP.Options;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HataMap());
            modelBuilder.Configurations.Add(new NotMap());
        }

        public DbSet<Hata> Hatalar { get; set; }
        public DbSet<Not> Notlar { get; set; }

    }
}
