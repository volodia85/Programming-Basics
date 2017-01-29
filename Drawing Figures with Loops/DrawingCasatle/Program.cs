using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingCasatle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var col = 2 * n;
            if (n <= 4)
            {
                Console.Write("/{0}\\/{0}\\", new string('^', n / 2));
                Console.WriteLine();
                for (int i = 1; i <= n - 2; i++)
                {
                    Console.WriteLine("|" + new string(' ', n * 2 - 2) + "|");
                }

                Console.Write("\\{0}/\\{0}/", new string('_', n / 2));
                Console.WriteLine();
            }
            else
            {
                Console.Write("/{0}\\{1}/{0}\\", new string ('^', n/2), new string ('_', n * 2 - 4 - 2 * (n / 2)) );
                Console.WriteLine();
                for (int i = 1; i <= n-3; i++)
                {
                    
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string(' ', n * 2 - 4 - 2 * (n / 2)));
                }
                Console.WriteLine("|{0}{1}{0}|", new string(' ', n/2+1), new string('_', n * 2 - 4 - 2 * (n / 2)));
                Console.Write("\\{0}/{1}\\{0}/", new string('_', n / 2),new string(' ', n * 2 - 4 - 2 * (n / 2)));
                Console.WriteLine();
            }

        }
    }
}
