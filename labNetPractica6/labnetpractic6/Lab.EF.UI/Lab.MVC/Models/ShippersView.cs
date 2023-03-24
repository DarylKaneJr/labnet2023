using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.MVC.Models
{
    public class ShippersView
    {
        public int ShippersID { get; set; }
        [Required]
              [StringLength(100)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }
    }
}