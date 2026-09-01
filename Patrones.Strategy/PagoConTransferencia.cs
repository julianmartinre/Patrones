using System;

namespace Patrones.Strategy
{
    internal class PagoConTransferencia : IEstrategiaPago
    {
        public void Pagar(decimal monto)
        {
            Console.WriteLine($"Pago por transferencia: ${monto:N2} (se genera un CBU de destino). ");
        }
    }
}
