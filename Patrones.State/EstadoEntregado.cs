using System;

namespace Patrones.State
{
    internal class EstadoEntregado : IEstadoPedido
    {
        public string Nombre { get { return "Entregado"; } }

        public void Pagar(Pedido pedido) { InformarFinalizado(); }
        public void Enviar(Pedido pedido) { InformarFinalizado(); }
        public void Entregar(Pedido pedido) { InformarFinalizado(); }

        private static void InformarFinalizado()
        {
            Console.WriteLine("El pedido ya fue entregado; no admite más operaciones.");
        }
    }
}
