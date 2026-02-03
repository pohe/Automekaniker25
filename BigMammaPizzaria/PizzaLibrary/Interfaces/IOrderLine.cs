using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IOrderLine
    {
        int Amount { get; set; }
        string Comment { get; set; }
        int Id { get; }
        IMenuItem MenuItem { get; }
        void AddExtraAccessory(IAccessory accessory);
        double SubTotal();
        string ToString();

    }
}
