using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class MenuItem : IMenuItem
    {
        private static int _counter = 0;
        private int _no;
        public MenuItem()
        {
        }
        public MenuItem(int no, string name, double price, string description, MenuType menuType)
        {
            Name = name;
            Price = price;
            Description = description;
            TheMenuType = menuType;
            _no = no;
        }
        //TODO
        public string Description { get; set; }
        public string Name { get; set; }
        public int No { get { return _no; } }

        public double Price { get; set; }
        public MenuType TheMenuType { get; set; }

        #region Methods
        public override string ToString()
        {
            return $"Nr {No} Navn {Name} Beskrivelse {Description} Price {Price} MenuType {TheMenuType.ToString()}";
        }


        #endregion
    }
}
