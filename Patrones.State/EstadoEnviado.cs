using System;

namespace Patrones.State
{
    internal class EstadoEnviado : IEstadoPedido
    {
        public string Nombre { get { return "Enviado"; } }

        public void Pagar(Pedido pedido)
        {
            Console.WriteLine("El pedido ya está pagado.");
        }

        public void Enviar(Pedido pedido)
        {
            Console.WriteLine("El pedido ya fue enviado.");
        }

        public void Entregar(Pedido pedido)
        {
            Console.WriteLine("Entrega confirmada.");
            pedido.CambiarEstado(new EstadoEntregado());
        }
    }
}
