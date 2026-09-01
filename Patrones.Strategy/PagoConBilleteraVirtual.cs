using System;

namespace Patrones.Strategy
{
    internal class PagoConBilleteraVirtual : IEstrategiaPago
    {
        public void Pagar(decimal monto)
        {
            Console.WriteLine($"Pago con billetera virtual: ${monto:N2} (se genera un codigo QR). ");
        }
    }
}
