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
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}