using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devide
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var number = 0;

            var devidedBy2 = 0.0;
            var devidedBy3 = 0.0;
            var devidedBy4 = 0.0;

            var counter = 0;
            for (int i = 1; i <= n; i++)
            {
                counter++;
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    devidedBy2++;
                }
                if (number % 3 == 0)
                {
                    devidedBy3++;
                }
                if (number % 4 == 0)
                {
                    devidedBy4++;
                }
            }

            Console.WriteLine("{0:f2}%", devidedBy2 / counter * 100);
            Console.WriteLine("{0:f2}%", devidedBy3 / counter * 100);
            Console.WriteLine("{0:f2}%", devidedBy4 / counter * 100);

        }
    }
}
