using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class CustomException : Exception
    {
        // punto 4
        public CustomException(string std) : base(String.Format("Nombre no valido {0}", std))
        {

        }
    }
}
