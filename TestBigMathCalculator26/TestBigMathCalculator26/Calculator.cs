using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBigMathCalculator26
{
    public class Calculator
    {
        public int Add(int tal1, int tal2)
        {
            return tal1 + tal2;
        }

        public int Multiply(int tal1, int tal2)
        {
            return tal1 * tal2;
        }

        public int Minus(int tal1, int tal2)
        {
            return tal1 - tal2;
        }

        public int Division(int tal1, int tal2)
        {
            if (tal2 == 0)
            {
                throw new DivideByZeroException();
            }
            return tal1 / tal2;
        }
    }
}
