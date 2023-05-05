using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public abstract class Disco
    {
        public string Nombre { get; set; }
        public double Capacidad { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return $"Disco: { Nombre } Capacidad: { Capacidad } Precio: { Precio }";
        }
    }
}
