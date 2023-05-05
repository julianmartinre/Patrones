using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Observer.Interfaces
{
    public interface IPalabra : IEntity
    {
        string Texto { get; set; }
    }
}
