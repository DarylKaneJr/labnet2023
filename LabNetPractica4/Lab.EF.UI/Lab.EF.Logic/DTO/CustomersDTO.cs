using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.DTO
{
    public class CustomersDTO
    {
        public string contactname { get; set; }
        public string region { get; set; }

        public DateTime? OrderDate { get; set; }
    }
}
