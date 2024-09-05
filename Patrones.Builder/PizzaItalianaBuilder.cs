using Patrones.Builder.Agregados;
using Patrones.Builder.Masas;
using Patrones.Builder.Salsas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder
{
    public class PizzaItalianaBuilder : PizzaBuilder
    {

        public PizzaItalianaBuilder()
        {
            _descripcion = "Pizza Italiana";
        }
        public override Agregado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Masa BuildMasa()
        {
            return new Piedra();
        }

        public override Salsa BuildSalsa()
        {
            return new Oliva();
        }
    }
}
