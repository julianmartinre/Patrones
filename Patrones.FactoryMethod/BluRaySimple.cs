using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class BluRaySimple : Disco
    {
        public BluRaySimple()
        {
            Nombre = "BluRaySimple";
            Capacidad = 50;
            Precio = 40;
        }
    }
}
