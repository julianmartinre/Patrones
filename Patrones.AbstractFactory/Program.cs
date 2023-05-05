using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produccion p = Produccion.GetInstance();

            Fabrica f = new FabricaSamsung();
            Celular c = p.ProducirCelular(f);
            Notebook n = p.ProducirNotebook(f);

            Console.WriteLine($"Celular: {c.nombre} Notebook: {n.nombre}.");

            f = new FabricaXiaomi();
            c = p.ProducirCelular(f);
            n = p.ProducirNotebook(f);

            Console.WriteLine($"Celular: {c.nombre} Notebook: {n.nombre}.");

            Console.ReadKey();
        }
    }
}
