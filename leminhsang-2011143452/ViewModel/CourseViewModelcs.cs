using leminhsang_2011143452.Models;
using System;
using System.Collections.Generic;

namespace CourseViewModelcs.ViewModel
{
    public class CourseViewModelcs
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime() 
        { 
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }
    }
}