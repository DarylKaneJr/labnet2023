using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoo1
{
    public class Perro : Animal
    {
        public Perro(int cantidadpatas) : base(cantidadpatas)
        {
        }

        public override string Caminar()
        {
            return string.Format("Yo avanzo en {0} patas", cantidadpatas);
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
