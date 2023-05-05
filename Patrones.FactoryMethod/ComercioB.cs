using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class ComercioB : Comercio
    {
        public override Disco CrearDisco(string tipoDisco)
        {
            switch (tipoDisco)
            {
                case "BluRaySimple":
                    return new BluRaySimple();
                case "BluRayDoble":
                    return new BluRayDoble();
                default:
                    return null;
            }
        }
    }
}
