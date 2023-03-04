using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoo1
{
    public abstract class Animal
    {
        public int cantidadpatas { get; set; }
        public Animal(int cantidadpatas)
        {
            this.cantidadpatas = cantidadpatas; 
        }
        public abstract string Caminar();
        public abstract string Descripcion();

    }
}
