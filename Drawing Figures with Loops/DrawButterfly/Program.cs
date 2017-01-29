using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawButterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var col = 2 * n - 1;
            var row = 2 * (n - 2) + 1;

            Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
            for (int i = 1; i <= n-3; i++)
            {
                
                Console.WriteLine("{0}\\ /{0}", new string('-',n-2));
                for (int c = 1 ; c <=n/2-1; c++)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 3));
                }

            }
            Console.WriteLine();
        }
    }
}
