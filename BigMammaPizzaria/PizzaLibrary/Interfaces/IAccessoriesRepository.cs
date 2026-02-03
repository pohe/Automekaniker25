using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IAccessoriesRepository
    {
        int Count { get; }
        List<IAccessory> GetAll();
        void AddAccessory(IAccessory accessory);
        IAccessory GetAccessoryById(int id);
        void RemoveAccessory(int id);
        void PrintAllAccessories();
    }
}
