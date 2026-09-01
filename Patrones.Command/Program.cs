using System;

namespace Patrones.Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoReceiver notebook = new ProductoReceiver("Notebook", 10);

            OrdenCommand ingresoDeMercaderia = new AltaStockCommand(notebook, 5);
            OrdenCommand venta = new BajaStockCommand(notebook, 3);
            OrdenCommand segundaVenta = new BajaStockCommand(notebook, 4);

            EmpresaInvoker empresa = new EmpresaInvoker();
            empresa.RecibirOrden(ingresoDeMercaderia);
            empresa.RecibirOrden(venta);
            empresa.RecibirOrden(segundaVenta);

            Console.WriteLine("Stock inicial de {0}: {1}.", notebook.Nombre, notebook.Stock);
            empresa.ProcesarOrdenes();
            Console.WriteLine("Stock final de {0}: {1}.", notebook.Nombre, notebook.Stock);

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
