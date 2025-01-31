using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automekaniker25
{
    public class Car : ICar
    {
        public string Regnr { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public int Milage { get; set; }
        public string Model { get; set; }
        
        public Car(string regNr, int year, string make, string model, int milage)
        {
            //Der skal testet
            Regnr = regNr;
            Year = year;
            Make = make;
            Model = model;
            Milage = milage;
        }

        public double TotalAutoRepairCost()
        {
            throw new NotImplementedException();
        }
    }
}
