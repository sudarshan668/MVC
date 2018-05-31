using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Login
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please Enter password ")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Use 5-20 characters")]
        [DataType(DataType.Password)]
        public string password{ get; set; }
    }
}