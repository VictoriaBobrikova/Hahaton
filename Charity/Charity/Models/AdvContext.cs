using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace Charity.Models
{
    public class ItemsContext : DbContext
    {
        public DbSet<DbItem> Items { get; set; }
    
    }

    public class ImageContext : DbContext
    {
 
        public DbSet<DbImage> Images { get; set; }
       
    }

    public class AdvContext : DbContext
    {
    
        public DbSet<DbAdv> Advertisememnts { get; set; }
    }
}