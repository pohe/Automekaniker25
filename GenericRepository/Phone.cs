using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class Phone
    {
        public int ProductionId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Phone(int productionId, string model, int year)
        {
            ProductionId = productionId;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"Phone productionId { ProductionId} Model {Model} Year {Year} ";
        }

    }
}
