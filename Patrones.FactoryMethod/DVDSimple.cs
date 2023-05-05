using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class DVDSimple : Disco
    {
        public DVDSimple()
        {
            Nombre = "DVDSimple";
            Capacidad = 4.7;
            Precio = 5;
        }
    }
}
