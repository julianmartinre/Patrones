using System;
using System.Collections.Generic;

namespace Patrones.Command
{
    internal class EmpresaInvoker
    {
        private readonly Queue<OrdenCommand> ordenes = new Queue<OrdenCommand>();

        public void RecibirOrden(OrdenCommand orden)
        {
            if (orden == null)
                throw new ArgumentNullException(nameof(orden));

            ordenes.Enqueue(orden);
        }

        public void ProcesarOrdenes()
        {
            while (ordenes.Count > 0)
            {
                OrdenCommand orden = ordenes.Dequeue();
                orden.Ejecutar();
            }
        }
    }
}
