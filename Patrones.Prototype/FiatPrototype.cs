using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype
{
    public class FiatPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (FiatPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Fiat {_modelo} color {_color}";
        }
    }
}
