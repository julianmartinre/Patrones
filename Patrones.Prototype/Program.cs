using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoPrototype prototipoFiat  = new FiatPrototype();
            AutoPrototype prototipoChevrolet = new FiatPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "negro";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatUno = prototipoFiat.Clonar();
            fiatUno.Modelo = "Uno SRC";
            fiatUno.Color = "blanco";
            Console.WriteLine(fiatUno.VerAuto());

            AutoPrototype chevroletCorsa = prototipoChevrolet.Clonar();
            chevroletCorsa.Modelo = "Corsa";
            chevroletCorsa.Color = "negro";
            Console.WriteLine(chevroletCorsa.VerAuto());

            AutoPrototype chevroletCelta = prototipoChevrolet.Clonar();
            chevroletCelta.Modelo = "Celta";
            chevroletCelta.Color = "blanco";
            Console.WriteLine(chevroletCelta.VerAuto());

            Console.ReadKey();
        }
    }
}
