using PizzaLibrary.Data;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Dictionary<string, ICustomer> _customers;
        public int Count { get { return _customers.Count; } }

        public CustomerRepository()
        {
            _customers = MockData.CustomerData;
        }



        public List<Customer> GetAllMembers()
        {
            List<Customer> result = new List<Customer>();
            foreach (Customer c in _customers.Values)
            {
                if (c.ClubMember == true)
                {
                    result.Add(c);
                }
            }
            return result;
        }

        public void AddCustomer2(int id, string name, string mobile, string address)
        {
            if (!_customers.ContainsKey(mobile))
            {
                Customer c = new Customer(id, name, mobile, address);
                _customers.Add(mobile, c);
            }
        }

        public void AddCustomer(Customer customer)
        {
            if (!_customers.ContainsKey(customer.Mobile))
            {
                _customers.Add(customer.Mobile, customer);
            }
        }
        public List<ICustomer> GetAll()
        {
            //List<Customer> clist = new List<Customer>();
            //foreach (Customer customer in _customers.Values.)
            //{
            //    clist.Add(customer);
            //}
            return _customers.Values.ToList();
        }

        public ICustomer GetCustomerByMobile(string mobile)
        {
            if (mobile != null && _customers.ContainsKey(mobile))
            {
                return _customers[mobile];
            }
            else
            {
                return null;
            }
        }

        public ICustomer? GetCustomerById(int id)
        {
            foreach (var cus in _customers.Values)
            {
                if (cus.Id == id)
                    return cus;
            }
            return null;

        }

        public void RemoveCustomer(string mobile)
        {
            if (mobile != null && _customers.ContainsKey(mobile))
            {
                _customers.Remove(mobile);
            }
        }

        public void PrintAllCustomers()
        {
            foreach (ICustomer customer in _customers.Values)
            {
                Console.WriteLine(customer);
            }
        }

        public override string ToString()
        {
            string returnString = "";
            foreach (ICustomer customer in _customers.Values)
            {
                returnString = customer.Name;
            }
            return returnString;
        }

        public void UpdateCustomer(ICustomer customer)
        {
            if (customer != null && _customers.ContainsKey(customer.Mobile))
            {
                _customers[customer.Mobile] = customer;
            }
        }

        public List<ICustomer> FilterCustomers(string name)
        {
            List<ICustomer> filteredList = new List<ICustomer>();
            foreach (var cu in _customers.Values)
            {
                if (cu.Name.Contains(name))
                {
                    filteredList.Add(cu);
                }
            }
            return filteredList;

        }

        List<ICustomer> ICustomerRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        ICustomer ICustomerRepository.GetCustomerByMobile(string mobile)
        {
            return GetCustomerByMobile(mobile);
        }

        ICustomer? ICustomerRepository.GetCustomerById(int id)
        {
            return GetCustomerById(id);
        }
    }
}
