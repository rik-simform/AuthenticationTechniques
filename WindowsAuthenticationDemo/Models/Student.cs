using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WindowsAuthenticationDemo.Models
{
    public class Student
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Course")]
        public string course { get; set; }

        [Display(Name = "Department")]
        public string department { get; set; }
    }
}