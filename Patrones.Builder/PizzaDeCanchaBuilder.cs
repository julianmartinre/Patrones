﻿using Patrones.Builder.Agregados;
using Patrones.Builder.Masas;
using Patrones.Builder.Salsas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Builder
{
    public class PizzaDeCanchaBuilder : PizzaBuilder
    {

        public PizzaDeCanchaBuilder()
        {
            _descripcion = "Pizza de cancha";
        }
        public override Agregado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Masa BuildMasa()
        {
            return new Integral();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}
