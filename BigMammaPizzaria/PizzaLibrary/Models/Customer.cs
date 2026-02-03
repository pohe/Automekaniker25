using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class Customer : ICustomer
    {
        private int _id;
        
        public string Address { get; set; }
        public bool ClubMember { get; set; }
        public int Id { get { return _id; } set { _id = value; } }

        public string Mobile { get; set; }

        public string Name { get; set; }

        public string CustomerImage { get; set; }

        public Customer()
        {
            
        }
        public Customer(int id, string name, string mobile, string address)
        {
            CustomerImage = "default.jpeg";
            _id = id;
            Name = name;
            Mobile = mobile;
            Address = address;
            ClubMember = false;
        }
        #region Methods
        public override string ToString()
        {
            return $"{_id} {Name} {Mobile} {Address} {(ClubMember ? "er medlem" : "Er ikke medlem")}";
        }
        #endregion
    }
}
