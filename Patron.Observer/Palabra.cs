using Patron.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Observer
{
    public class Palabra : Entity, IPalabra
    {
        public string Texto { get; set; }
    }
}
