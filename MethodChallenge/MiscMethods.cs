using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChallenge
{
    public static class MiscMethods
    {
        public static void Operate(double x, double y, out double added, out double subtracted, out double multiplied, out double divided)
        {
            added = x + y;
            subtracted = x - y;
            multiplied = x * y;
            divided = x / y;
        }

        public static  (double, double, double, double) OperateTuple(double x, double y)
        {
            double added = x + y;
            double subtracted = x - y;
            double multiplied = x * y;
            double divided = x / y;
            return (added, subtracted, multiplied, divided);

        }


    }
}
