using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido();

            Console.WriteLine("Estado inicial: " + pedido.EstadoActual);
            pedido.Enviar();
            pedido.Pagar();
            pedido.Enviar();
            pedido.Entregar();
            pedido.Pagar();

            Console.WriteLine("Estado final: " + pedido.EstadoActual);
            Console.ReadKey();
        }
    }
}
