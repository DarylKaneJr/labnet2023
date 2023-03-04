using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoo1
{
    public class Persona : Animal
    {
        public Persona(int cantidadpatas) : base(cantidadpatas)
        {
        }

        public override string Caminar()
        {
            return $"Yo avanzo en {cantidadpatas} patas";
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
