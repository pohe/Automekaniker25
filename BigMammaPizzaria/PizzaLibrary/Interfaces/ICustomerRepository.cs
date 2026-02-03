using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface ICustomerRepository
    {
        public int Count { get; }
        List<ICustomer> GetAll();
        void AddCustomer(ICustomer customer);
        ICustomer GetCustomerByMobile(string mobile);
        void RemoveCustomer(string mobile);
        void PrintAllCustomers();
        ICustomer? GetCustomerById(int id);
        void UpdateCustomer(ICustomer customer);
        void AddCustomer2(string name, string mobile, string address);
        List<ICustomer> FilterCustomers(string name);

    }
}
