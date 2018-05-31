using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MVCContex:DbContext
    {
        public MVCContex() : base("conn") { }
        public DbSet<Login> Logins { get; set; }
        public DbSet<demo> demos { get; set; }
    }
}