using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class Order : IOrder
    {
        #region instance fields
        private int _id;
        private DateTime _created;
        private List<IOrderLine> _lines;
        private Customer _customer;
        #endregion

        #region Properties
        public int Id { get { return _id; } }
        #endregion

        public DateTime Created { get { return _created; } }

        public Customer Customer { get { return _customer; } }
        public bool ToBeDelivered { get; private set; }

        #region Constructors
        public Order(Customer customer, bool toBeDelivered) : this()
        {
            _customer = customer;
            ToBeDelivered = toBeDelivered;
        }
        public Order(int id)
        {
            _id = id;
            _created = DateTime.Now;
            _lines = new List<IOrderLine>();
        }
        #endregion

        #region Methods
        public void AddOrderLine(IOrderLine line)
        {
            _lines.Add(line);
        }

        public double CalculateTotal()
        {
            double total = 0;
            //TODO: implementer denne metode
            return total;
        }

        public void PrintReciept()
        {
            Console.WriteLine($"Order nummer {_id}");
            Console.WriteLine($"Orderdato {_created.ToShortDateString()}");
            foreach (OrderLine line in _lines)
            {
                Console.WriteLine(line.ToString());
            }
            Console.WriteLine($"Total pris {CalculateTotal()} kr. moms {CalculateTotal() / 5}");
        }

        public List<IOrderLine> GetAllOrderLines()
        {
            return _lines;
        }

        
        #endregion
    }
}
