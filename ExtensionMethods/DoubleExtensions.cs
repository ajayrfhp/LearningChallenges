using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class DoubleExtensions
    {
        public static double Add(this double x, double y)
        {
            return x + y;
        }

        public static double Multiply(this double x, double y)
        {
            return x * y;
        }

        public static double Subtract(this double x, double y)
        {
            return x - y;
        }

        public static double Divide(this double x, double y)
        {
            return x / y;
        }



    }
}
