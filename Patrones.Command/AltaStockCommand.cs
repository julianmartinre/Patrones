namespace Patrones.Command
{
    internal class AltaStockCommand : OrdenCommand
    {
        private readonly ProductoReceiver producto;
        private readonly int cantidad;

        public AltaStockCommand(ProductoReceiver producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public override void Ejecutar()
        {
            producto.DarDeAlta(cantidad);
        }
    }
}
