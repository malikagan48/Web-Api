using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ODEV2MUSTAFALİKAGANKUCUK.Models
{
    public class Bootcamp
    {
        [Display(Name = "Bootcamp ID")]
        [Required(ErrorMessage ="Bootcamp numarası seçimi zorunludur.")]
        public int BootcampID { get; set; }
        public string Name { get; set; }
  
  
    }
}