using System;

namespace Patrones.Strategy
{
    internal class ProcesadorDePagos
    {
        private IEstrategiaPago _estrategia;

        public ProcesadorDePagos(IEstrategiaPago estrategia)
        {
            _estrategia = estrategia ?? throw new ArgumentNullException(nameof(estrategia));
        }

        public void CambiarEstrategia(IEstrategiaPago estrategia)
        {
            _estrategia = estrategia ?? throw new ArgumentNullException(nameof(estrategia));
        }

        public void Procesar(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto), "El monto debe ser mayor que cero.");
            }

            _estrategia.Pagar(monto);
        }
    }
}
