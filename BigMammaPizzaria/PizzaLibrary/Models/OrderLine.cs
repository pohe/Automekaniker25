using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class OrderLine : IOrderLine
    {
        #region Instance fields
        private static int _count = 0;
        private int _id;
        private int _amount;
        private IMenuItem _menuItem;
        private List<IAccessory> _accessories;
        #endregion

        #region Properties
        public int Id { get { return _id; } }
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public IMenuItem MenuItem { get { return _menuItem; } }
        public string Comment { get; set; }
        #endregion

        #region Constructors
        public OrderLine(IMenuItem menuItem, int amount, string comment)
        {
            _count++;
            _id = _count;
            _menuItem = menuItem;
            _amount = amount;
            Comment = comment;
            _accessories = new List<IAccessory>();
        }
        #endregion

        #region Methods

        public void AddExtraAccessory(IAccessory accessory)
        {
            _accessories.Add(accessory);
        }
        public double SubTotal()
        {
            double accessoriesTotal = 0;
            foreach (var accessories in _accessories)
            {
                // accessoriesTotal = accessoriesTotal + accessories.Price;
            }
            return _amount * _menuItem.Price + accessoriesTotal;
        }

        public List<IAccessory> GetAllAccessory()
        {
            return _accessories;
        }

        public override string ToString()
        {
            string extraAccessories = "";
            foreach (Accessory accessory in _accessories)
            {
                extraAccessories += accessory.ToString();
            }
            return $"{_menuItem.Name} {_amount} {Comment} {extraAccessories}";
        }

        
        #endregion
    }
}
