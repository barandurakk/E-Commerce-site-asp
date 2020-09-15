using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniETicaret.MvcWeb.Entity
{
    public class DataContext:DbContext
    {
        public DataContext(): base("dataConnection")  //connection string ismi(ctor)
        {
            Database.SetInitializer(new DataInitializer());   //Datinitializerimizi devreye sokuyoruz.
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}