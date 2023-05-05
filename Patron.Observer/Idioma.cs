using Patron.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Observer
{
    public class Idioma : Entity, IIdioma
    {
        public string Nombre { get; set; }
        public IList<ITraduccion> Traducciones { get; set; }

        public Idioma()
        {
            Traducciones = new List<ITraduccion>();
        }
        public void AgregarTraduccion(ITraduccion traduccion)
        {
            Traducciones.Add(traduccion);
        }

        public string BuscarTraduccion(string texto)
        {
            return Traducciones.FirstOrDefault(x => x.Palabra.Texto == texto).PalabraTraducida;
        }
    }
}
