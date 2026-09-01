namespace Patrones.Command
{
    internal class BajaStockCommand : OrdenCommand
    {
        private readonly ProductoReceiver producto;
        private readonly int cantidad;

        public BajaStockCommand(ProductoReceiver producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public override void Ejecutar()
        {
            producto.DarDeBaja(cantidad);
        }
    }
}
