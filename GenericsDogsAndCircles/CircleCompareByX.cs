using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class CircleCompareByX : IComparer<Circle>
    {
        public int Compare(Circle? x, Circle? y)
        {
            if (x == null) return -1;
            if (y == null) return 1;
            if (x.X > y.X) return 1;
            if (y.X > x.X) return -1;
            else
                return 0;
        }
    }
}
