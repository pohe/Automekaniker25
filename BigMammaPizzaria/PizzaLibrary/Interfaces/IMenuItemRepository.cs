using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IMenuItemRepository
    {
        int Count { get; }
        List<IMenuItem> GetAll();
        void AddMenuItem(IMenuItem menuItem);
        IMenuItem GetMenuItemByNo(int no);
        void RemoveMenuItem(int no);
        void PrintAllMenuItems();
        List<IMenuItem> FilterMenuItems(string filterCriteria);
        void UpdateMenuItem(int no, string name, string description, double price, IMenuType upDatedMenuType);
    }
}
