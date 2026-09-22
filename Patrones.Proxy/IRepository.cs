using System.Collections.Generic;

namespace Patrones.Proxy
{
    public interface IRepository
    {
        IList<Customer> GetAll();
        void Save(Customer customer);
    }
}