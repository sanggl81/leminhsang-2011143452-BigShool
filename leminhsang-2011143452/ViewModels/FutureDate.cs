using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace leminhsang_2011143452.ViewModels
{
    
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "dd/M/yyyy", CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None, out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }

    }
}