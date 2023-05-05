using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public abstract class Fabrica
    {
        public abstract Celular CrearCelular();
        public abstract Notebook CrearNotebook();
    }
}
