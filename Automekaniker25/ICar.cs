using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automekaniker25
{
    public interface ICar
    {
        string Regnr { get; set; }
        int Year { get; set; }
        string Make { get; set; }
        int Milage { get; set; }
        string Model { get; set; }
        //Owner Owner { get; set; }

        //void AddOwner(Owner owner);
        //void AddRepair(AutoRepair autoRepair);
        string ToString();
        double TotalAutoRepairCost();

    }
}
