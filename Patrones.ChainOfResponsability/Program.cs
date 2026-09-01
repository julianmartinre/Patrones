using System;

namespace Patrones.ChainOfResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gerenteZonal = new GerenteZonal();
            var gerenteProvincial = new GerenteProvincial();
            var director = new Director();

            gerenteZonal
                .EstablecerSiguiente(gerenteProvincial)
                .EstablecerSiguiente(director);

            var solicitudes = new[]
            {
                new SolicitudCompra("Insumos de oficina", 99.99m),
                new SolicitudCompra("Silla ergonómica", 100m),
                new SolicitudCompra("Equipamiento informático", 1000m),
                new SolicitudCompra("Servidor", 1000.01m)
            };

            foreach (var solicitud in solicitudes)
            {
                gerenteZonal.Procesar(solicitud);
            }
        }
    }
}
