using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype
{
    public class ChevroletPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (ChevroletPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Chevrolet {_modelo} color {_color}";
        }
    }
}
