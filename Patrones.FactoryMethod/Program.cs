using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Comercio comercio;
            Disco disco;

            comercio = new ComercioA();
            disco = comercio.CrearDisco("DVDSimple");
            Console.WriteLine(disco.ToString());
            disco = comercio.CrearDisco("DVDDoble");
            Console.WriteLine(disco.ToString());

            comercio = new ComercioB();
            disco = comercio.CrearDisco("BluRaySimple");
            Console.WriteLine(disco.ToString());
            disco = comercio.CrearDisco("BluRayDoble");
            Console.WriteLine(disco.ToString());
            Console.ReadKey();
        }
    }
}