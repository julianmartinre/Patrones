using System;

namespace Patrones.Strategy
{
    internal class PagoConTarjeta : IEstrategiaPago
    {
        public void Pagar(decimal monto)
        {
            Console.WriteLine($"Pago con tarjeta: ${monto:N2} (incluye validación de tarjeta). ");
        }
    }
}
