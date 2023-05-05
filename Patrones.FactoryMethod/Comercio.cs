using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public abstract class Comercio
    {
        public abstract Disco CrearDisco(string tipoDisco);
    }
}
