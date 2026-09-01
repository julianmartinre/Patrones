namespace Patrones.State
{
    internal interface IEstadoPedido
    {
        string Nombre { get; }
        void Pagar(Pedido pedido);
        void Enviar(Pedido pedido);
        void Entregar(Pedido pedido);
    }
}
