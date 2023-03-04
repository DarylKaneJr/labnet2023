using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public abstract class TransportePublico
    {
        private string id { get; set; }
        private int pasajeros { get; set; }
        public TransportePublico(string _id, int _pasajeros)
        {
            this.pasajeros = _pasajeros;
            this.id = _id;
        }
        public virtual string GetID ()
        {
            return id;
        }
        public virtual int Getpasajeros()
        {
            return pasajeros;
        }
        public abstract string Avanzar();
        public abstract string Detenerse() ;
    }
}
