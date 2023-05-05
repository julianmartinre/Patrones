using Patron.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Observer
{
    public class Sesion : IObservado
    {
        public Idioma idioma { get; set; }
        public IList<IObservador> ObservadoresRegistrados { get; set; }
        private static Sesion sesion;

        private Sesion()
        {
            ObservadoresRegistrados = new List<IObservador>();
        }

        public static Sesion GetInstance()
        {
            if (sesion == null)
            {
                sesion = new Sesion();
            }
            return sesion;
        }

        public void CambiarIdioma(Idioma i)
        {
            idioma = i;
            ActualizarObservadores(i);
        }

        public void ActualizarObservadores(IIdioma idioma)
        {
            foreach (var item in ObservadoresRegistrados)
            {
                item.Actualizar(idioma);
            }
        }

        public void DesregistrarObservador(IObservador observador)
        {
            ObservadoresRegistrados.Add(observador);
        }

        public void RegistrarObservador(IObservador observador)
        {
            ObservadoresRegistrados.Add(observador);
        }
    }
}
