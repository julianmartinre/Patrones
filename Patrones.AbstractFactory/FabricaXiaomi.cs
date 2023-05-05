using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class FabricaXiaomi : Fabrica
    {
        public override Celular CrearCelular()
        {
            return new Celular9T();
        }

        public override Notebook CrearNotebook()
        {
            return new NotebookPower();
        }
    }
}
