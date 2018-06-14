using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class CustomerDetails
    {
        public int CustomerDetailsid { get; set; }
        [Required(ErrorMessage = "Please Enter Email Address")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please Enter Email Address")]
        public DateTime BirthdayDate { get; set; }
        [Required(ErrorMessage = "Please Enter Email Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please Enter Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string email { get; set; }

        public virtual ICollection<purchased> Purchased { get; set; }


       }
}