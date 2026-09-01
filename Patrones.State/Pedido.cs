using System;

namespace Patrones.State
{
    internal class Pedido
    {
        private IEstadoPedido _estado;

        public Pedido()
        {
            _estado = new EstadoPendiente();
        }

        public string EstadoActual { get { return _estado.Nombre; } }

        public void Pagar() { _estado.Pagar(this); }
        public void Enviar() { _estado.Enviar(this); }
        public void Entregar() { _estado.Entregar(this); }

        internal void CambiarEstado(IEstadoPedido nuevoEstado)
        {
            Console.WriteLine("Transición: {0} -> {1}", _estado.Nombre, nuevoEstado.Nombre);
            _estado = nuevoEstado;
        }
    }
}
