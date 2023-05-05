using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class DVDDoble : Disco
    {
        public DVDDoble()
        {
            Nombre = "DVDDoble";
            Capacidad = 8.5;
            Precio = 8;
        }
    }
}
