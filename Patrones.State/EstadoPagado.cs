using System;

namespace Patrones.State
{
    internal class EstadoPagado : IEstadoPedido
    {
        public string Nombre { get { return "Pagado"; } }

        public void Pagar(Pedido pedido)
        {
            Console.WriteLine("El pedido ya está pagado.");
        }

        public void Enviar(Pedido pedido)
        {
            Console.WriteLine("Pedido despachado.");
            pedido.CambiarEstado(new EstadoEnviado());
        }

        public void Entregar(Pedido pedido)
        {
            Console.WriteLine("El pedido debe enviarse antes de ser entregado.");
        }
    }
}
