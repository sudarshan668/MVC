using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class OverEighteenYearsOld : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && value is DateTime && ((DateTime)value).AddYears(18).Date <= DateTime.Now.Date;
        }
    }
}