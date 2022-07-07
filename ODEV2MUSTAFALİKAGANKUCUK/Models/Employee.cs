using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ODEV2MUSTAFALİKAGANKUCUK.Models
{
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}