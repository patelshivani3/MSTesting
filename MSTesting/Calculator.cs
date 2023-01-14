using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTesting
{
    public class Calculator
    {
        public int Addition(int a, int b)
        { 
            return a + b; 
        }
        public int Substraction(int a, int b)
        {
            return Math.Abs(a - b);
        }
    }
}
