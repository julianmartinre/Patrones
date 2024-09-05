using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Masas
{
    public abstract class Masa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
}
