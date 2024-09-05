using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder.Agregados
{
    public abstract class Agregado
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }
}