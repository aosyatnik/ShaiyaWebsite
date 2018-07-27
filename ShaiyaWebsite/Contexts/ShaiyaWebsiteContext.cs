using ShaiyaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShaiyaWebsite.Contexts
{
    public class ShaiyaWebsiteContext : DbContext
    {
        public ShaiyaWebsiteContext()
            : base("name=ShaiyaWebsiteContext")
        {

        }

        public DbSet<User> Users { get; set; } 
    }
}