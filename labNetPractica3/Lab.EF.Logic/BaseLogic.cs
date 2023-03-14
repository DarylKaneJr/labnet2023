using Lab.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NortwindContext context;
        public BaseLogic()
        {
            context = new NortwindContext();
        }
    }
}
