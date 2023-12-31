using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public static class PersonModelExtensions
    {
        public static PersonModel Fill(this PersonModel personModel)
        {
            Console.WriteLine("Enter first and last names");
            try
            {
                personModel.FirstName = Console.ReadLine();
                personModel.LastName = Console.ReadLine();
                return personModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return null;
            }
        }

        public static void Print(this PersonModel personModel)
        {
            personModel.DisplayObject();
        }
    }
}
