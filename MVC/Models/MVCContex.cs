﻿using System;
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
        public DbSet<sweetalert> sweetalert { get; set; }
        public System.Data.Entity.DbSet<MVC.Models.product> products { get; set; }
        // public DbSet<demo2onbaseddemo> demo2onbaseddemo { get; set; }
    }
}