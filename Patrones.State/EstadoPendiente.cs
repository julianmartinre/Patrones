using System;

namespace Patrones.State
{
    internal class EstadoPendiente : IEstadoPedido
    {
        public string Nombre { get { return "Pendiente"; } }

        public void Pagar(Pedido pedido)
        {
            Console.WriteLine("Pago registrado.");
            pedido.CambiarEstado(new EstadoPagado());
        }

        public void Enviar(Pedido pedido)
        {
            Console.WriteLine("El pedido debe pagarse antes de ser enviado.");
        }

        public void Entregar(Pedido pedido)
        {
            Console.WriteLine("El pedido debe pagarse y enviarse antes de ser entregado.");
        }
    }
}
