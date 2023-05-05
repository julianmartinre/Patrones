using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class BluRayDoble : Disco
    {
        public BluRayDoble()
        {
            Nombre = "BluRayDoble";
            Capacidad = 25;
            Precio = 20;
        }
    }
}
