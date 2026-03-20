using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class DogCompareByHeight : IComparer<Dog>
    {
        public int Compare(Dog? x, Dog? y)
        {
            if (x == null) return -1;
            if (y == null) return 1;
            if (x.Height > y.Height) return 1;
            if (y.Height > x.Height) return -1;
            else return 0; 

        }
    }
}
