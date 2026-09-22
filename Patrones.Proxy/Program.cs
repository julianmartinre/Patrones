using System;

namespace Patrones.Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRepository repo = new CustomerRepositoryProxy();

                Session.CanSave = true;
                Session.CanGetAll = true;

                Customer p1 = new Customer("customer 1");
                Customer p2 = new Customer("customer 2");

                repo.Save(p1);
                repo.Save(p2);

                foreach (var p in repo.GetAll())
                {
                    Console.WriteLine($"{p.Name}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}