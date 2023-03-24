using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomException : Exception
    {
        public CustomException(string std) : base(String.Format("Nombre no valido {0}", std))
        {
        }
    }
}
