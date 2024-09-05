using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Salsas
{
    public abstract class Salsa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
}
