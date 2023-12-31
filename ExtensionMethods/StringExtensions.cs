using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static void Print(this string s) 
        { 
            Console.WriteLine(s);
        }

        public static string Excite(this string s)
        {
            return s.Replace('.', '!');
        }
    }
}
