using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ListExtensions
    {
        public static void Print<T>(this List<T> list)
        {
            foreach(var item in list) 
            { 
                Console.Write(item.ToString() + ",");
            }
        }
    }
}
