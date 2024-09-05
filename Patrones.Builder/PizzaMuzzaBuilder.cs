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
    public class PizzaMuzzaBuilder : PizzaBuilder
    {
        public PizzaMuzzaBuilder()
        {
            _descripcion = "Pizza de Muzzarela";
        }
        public override Agregado BuildAgregado()
        {
            return new Oregano();
        }

        public override Masa BuildMasa()
        {
            return new Molde();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}
