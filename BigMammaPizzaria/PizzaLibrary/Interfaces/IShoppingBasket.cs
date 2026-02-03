using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IShoppingBasket
    {
        List<IOrderLine> GetAll();
        void AddOrderLine(IOrderLine orderLine);
        void RemoveOrderLine(int id);
        public int Count { get; }

        public ICustomer CurrentCustomer { get; set; }
        public void ClearAll();
        public IOrderLine? GetOrderLineById(int id);
        bool ToBeDelivered { get; set; }
    }
}
