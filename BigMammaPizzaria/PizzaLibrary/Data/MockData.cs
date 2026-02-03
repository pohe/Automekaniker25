using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Data
{
    public static class MockData
    {
        #region Instance fields
        private static Dictionary<string, ICustomer> _customerData =
            new Dictionary<string, ICustomer>()
            {
            { "12121212", new Customer(1, "Mikkel", "12121212", "Street 123") },
            { "13131313", new Customer(2, "Charlotte", "13131313", "Avenue 321") },
            { "14141414", new Customer(3, "Carina", "14141414", "High Street 234") },
            { "15151515", new Customer(4, "Mohammed", "15151515", "North Street 345") }
            };

        private static List<IMenuItem> _menuItemData =
            new List<IMenuItem>()
            {
            new MenuItem(1, "Margherita", 85, "Tomat, ost", MenuType.PIZZECLASSSICHE),
            new MenuItem(2, "Vesuvio", 95, "Tomat, ost & skinke", MenuType.PIZZECLASSSICHE),
            new MenuItem(3, "Capricciosa", 98, "Tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
            new MenuItem(4, "Calzone", 98, "Indbagt pizza med tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
            new MenuItem(5, "Quattro Stagioni", 98, "Tomat, ost, skinke, champignon, rejer & paprika", MenuType.PIZZECLASSSICHE),
            new MenuItem(6, "Marinara", 97, "Tomat, ost, rejer, muslinger & hvidløg", MenuType.PIZZECLASSSICHE),
            new MenuItem(7, "Vegetariana", 98, "Tomat, ost & grønsager", MenuType.PIZZECLASSSICHE),
            new MenuItem(8, "Italiana", 97, "Tomat, ost, løg & kødsauce", MenuType.PIZZECLASSSICHE)

            };

        private static List<IAccessory> _AccessoryData =
           new List<IAccessory>()
           {
                new Accessory(1,"Ananas", 10),
                new Accessory(2, "Artiskok", 10),
                new Accessory(3, "løg", 10),
                new Accessory(4, "Ost", 15),
                new Accessory(5, "Gorgonzola", 20),
                new Accessory(6, "pepperoni", 20),
                new Accessory(7, "kødstrimler", 20),
                new Accessory(8, "rejer", 20)
           };
        #endregion

        #region Properties
        public static Dictionary<string, ICustomer> CustomerData
        {
            get { return _customerData; }
        }

        public static List<IMenuItem> MenuItemData
        {
            get { return _menuItemData; }
        }

        public static List<IAccessory> AccessoryData
        {
            get { return _AccessoryData; }
        }

        #endregion
    }
}
