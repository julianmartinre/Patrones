using System;

namespace Patrones.ChainOfResponsability
{
    internal class SolicitudCompra
    {
        public SolicitudCompra(string descripcion, decimal importe)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descripción es obligatoria.", nameof(descripcion));
            }

            if (importe < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(importe), "El importe no puede ser negativo.");
            }

            Descripcion = descripcion;
            Importe = importe;
        }

        public string Descripcion { get; }

        public decimal Importe { get; }
    }
}
