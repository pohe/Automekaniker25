using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class CompanyInfoSingleton
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public double Vat { get; set; }
        public string CVR { get; set; }
        public int ClubDiscount { get; set; }

        public int DeliveryCost { get; set; }

        //Skal implementeres som en singleton
    }
}
