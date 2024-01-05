using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            int paidItems = 0;
            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    var result = paymentProcessor.MakePayment($"Demo{i}", i);
                    if(result != null)
                    {
                        Console.WriteLine(result.TransactionAmount);
                        paidItems++;
                    }
                    
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Skipped invalid record {0}", ex.InnerException?.Message);
                }
                catch (FormatException ex) when (i != 5)
                {

                    Console.WriteLine("Formatting issue {0}", ex.InnerException?.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Payment has been skipped for {0} items", 10 - paidItems);
                    Console.WriteLine(ex.InnerException?.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
