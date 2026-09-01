using System;
namespace Patrones.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var procesador = new ProcesadorDePagos(new PagoConTarjeta());

            procesador.Procesar(1500m);

            procesador.CambiarEstrategia(new PagoConTransferencia());
            procesador.Procesar(2300m);

            procesador.CambiarEstrategia(new PagoConBilleteraVirtual());
            procesador.Procesar(800m);
        }
    }
}
