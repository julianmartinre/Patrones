using System;

namespace Patrones.Command
{
    internal class ProductoReceiver
    {
        public ProductoReceiver(string nombre, int stockInicial)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El producto debe tener un nombre.", nameof(nombre));

            if (stockInicial < 0)
                throw new ArgumentOutOfRangeException(nameof(stockInicial), "El stock no puede ser negativo.");

            Nombre = nombre;
            Stock = stockInicial;
        }

        public string Nombre { get; }

        public int Stock { get; private set; }

        public void DarDeAlta(int cantidad)
        {
            ValidarCantidad(cantidad);
            Stock += cantidad;
            Console.WriteLine("Alta de {0} unidad(es) de {1}. Stock actual: {2}.", cantidad, Nombre, Stock);
        }

        public void DarDeBaja(int cantidad)
        {
            ValidarCantidad(cantidad);

            if (cantidad > Stock)
                throw new InvalidOperationException(
                    string.Format("No hay stock suficiente de {0}. Disponible: {1}; solicitado: {2}.", Nombre, Stock, cantidad));

            Stock -= cantidad;
            Console.WriteLine("Baja de {0} unidad(es) de {1}. Stock actual: {2}.", cantidad, Nombre, Stock);
        }

        private static void ValidarCantidad(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad debe ser mayor que cero.");
        }
    }
}
