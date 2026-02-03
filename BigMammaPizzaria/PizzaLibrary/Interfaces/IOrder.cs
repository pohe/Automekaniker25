using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IOrder
    {
        int Id { get; }
        bool ToBeDelivered { get; }
        void AddOrderLine(IOrderLine line);
        double CalculateTotal();
        void PrintReciept();
        public List<IOrderLine> GetAllOrderLines();
    }
}
