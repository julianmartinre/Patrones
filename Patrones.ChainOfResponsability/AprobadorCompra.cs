using System;

namespace Patrones.ChainOfResponsability
{
    internal abstract class AprobadorCompra
    {
        private AprobadorCompra siguiente;

        public AprobadorCompra EstablecerSiguiente(AprobadorCompra aprobador)
        {
            siguiente = aprobador ?? throw new ArgumentNullException(nameof(aprobador));
            return aprobador;
        }

        public void Procesar(SolicitudCompra solicitud)
        {
            if (solicitud == null)
            {
                throw new ArgumentNullException(nameof(solicitud));
            }

            if (PuedeAprobar(solicitud.Importe))
            {
                Aprobar(solicitud);
                return;
            }

            if (siguiente == null)
            {
                throw new InvalidOperationException(
                    $"No existe un aprobador para el importe {solicitud.Importe:C}.");
            }

            siguiente.Procesar(solicitud);
        }

        protected abstract bool PuedeAprobar(decimal importe);

        protected abstract string Cargo { get; }

        private void Aprobar(SolicitudCompra solicitud)
        {
            Console.WriteLine(
                $"{Cargo} aprobó la compra '{solicitud.Descripcion}' por {solicitud.Importe:C}.");
        }
    }
}
