using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                try
                { 
                Console.Write("Enter even number: ");
                var n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", n);
                    break;
                }
                
                
                   if (!(n % 2 == 0))
                    {

                        Console.WriteLine("The number is not even.");
                        Console.Write("Enter even number: ");
                        n = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number!");
                    continue;
                }
                
            }
        }
    }
}
