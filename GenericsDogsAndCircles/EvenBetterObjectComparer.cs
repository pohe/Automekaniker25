using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles
{
    public class EvenBetterObjectComparer<T>
    {

        public T Largest(T a, T b, T c, IComparer<T> comparer)
        {
            if (comparer.Compare( a, b) > 0)
            {
                return comparer.Compare(a, c) > 0 ? a : c;
            }

            return comparer.Compare(b,c) > 0 ? b : c;
        }
    }
}
