using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class product
    {
        public int productid { get; set; }
        public string  name { get; set; }
        public int price { get; set; }

       public virtual ICollection<purchased> Purchased { get; set; }

    }
}