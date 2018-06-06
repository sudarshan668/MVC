using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class demo
    {
        public int id { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please Enter valid Date")]
        //[DataType(DataType.Date)]
        //[Range(typeof(DateTime), "1/1/1966", "1/1/2017")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [OverEighteenYearsOld]
        public DateTime Birthdate { get; set; }


    }
}