using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class purchased
    {
        public int purchasedid { get; set; }
        public int productid { get; set; }
        public int CustomerDetailsid { get; set; }

        public virtual product product { get; set; }
        public virtual CustomerDetails CustomerDetails { get; set; }
    }
}