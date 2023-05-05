using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class ComercioA : Comercio
    {
        public override Disco CrearDisco(string tipoDisco)
        {
            switch (tipoDisco)
            {
                case "DVDSimple":
                    return new DVDSimple();
                case "DVDDoble":
                    return new DVDDoble();
                default:
                    return null;
            }
        }
    }
}
