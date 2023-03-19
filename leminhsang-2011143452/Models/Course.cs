using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace leminhsang_2011143452.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]

        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]

        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
        public int DataTime { get; internal set; }
    }
    
}