using Patron.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Observer
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
