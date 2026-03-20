using SailClubLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailClubLibrary.Helpers.Sorting
{
    public class BoatCompareByYear : IComparer<Boat>
    {
        public int Compare(Boat? x, Boat? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            // Assuming YearOfConstruction is a string, try to parse to int for comparison
            //int yearX = 0, yearY = 0;
            //int.TryParse(x.YearOfConstruction, out yearX);
            //int.TryParse(y.YearOfConstruction, out yearY);
            //return yearX.CompareTo(yearY);
            return x.YearOfConstruction.CompareTo(y.YearOfConstruction);
        }
    }
}
