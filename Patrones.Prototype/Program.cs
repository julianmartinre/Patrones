using System;
using System.Collections.Generic;

namespace Patrones.Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AutoPrototype prototipoFiat = new FiatPrototype
            {
                Modelo = "Base Fiat", Color = "blanco", Motor = new Motor("1.4", 85),
                Equipamiento = new List<string> { "ABS", "Airbag" }
            };
            AutoPrototype prototipoChevrolet = new ChevroletPrototype
            {
                Modelo = "Base Chevrolet", Color = "gris", Motor = new Motor("1.6", 92),
                Equipamiento = new List<string> { "ABS", "Airbag", "Aire acondicionado" }
            };

            var catalogo = new CatalogoPrototipos();
            catalogo.Registrar("fiat-base", prototipoFiat);
            catalogo.Registrar("chevrolet-base", prototipoChevrolet);

            AutoPrototype fiatPalio = catalogo.Crear("fiat-base");
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "negro";
            fiatPalio.Equipamiento.Add("Alarma");

            AutoPrototype chevroletCorsa = catalogo.Crear("chevrolet-base");
            chevroletCorsa.Modelo = "Corsa";
            chevroletCorsa.Color = "azul";

            Console.WriteLine("Autos creados desde el catálogo:");
            Console.WriteLine(fiatPalio);
            Console.WriteLine(chevroletCorsa);
            MostrarDiferenciaEntreClonaciones(prototipoFiat);
            Console.ReadKey();
        }

        private static void MostrarDiferenciaEntreClonaciones(AutoPrototype original)
        {
            Console.WriteLine("\nClonación superficial:");
            AutoPrototype superficial = original.ClonarSuperficial();
            superficial.Motor.Potencia = 100;
            superficial.Equipamiento.Add("GPS");
            Console.WriteLine($"Potencia original: {original.Motor.Potencia} CV");
            Console.WriteLine("El original cambió porque comparte Motor y Equipamiento con el clon.");

            Console.WriteLine("\nClonación profunda:");
            AutoPrototype profundo = original.Clonar();
            profundo.Motor.Potencia = 120;
            profundo.Equipamiento.Add("Techo solar");
            Console.WriteLine($"Potencia original: {original.Motor.Potencia} CV");
            Console.WriteLine($"Potencia del clon: {profundo.Motor.Potencia} CV");
            Console.WriteLine("El clon profundo puede cambiar sin afectar al original.");
        }
    }
}
