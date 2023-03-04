using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(string _id, int _pasajeros) : base(_id, _pasajeros)
        {
        }
        public override string Avanzar()
        {
            return string.Format("El " + GetID() + " avanza con : " + Getpasajeros() + " pasajeros");
        }
        public override string Detenerse()
        {
            return string.Format("El " + GetID() + " se detiene dejando : " + Getpasajeros() + " pasajeros");
        }
    }
}
