using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n * 2 + 1));

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}//{1}\\{0}", new string('.', n + 1 - row), new string('_', (n * 2) - 1 + row * 2 - 2) + "\\");

            }
            Console.Write("//{0}STOP!{0}\\\\", new string('_', (n * 2 - 3)));
            Console.WriteLine();
            for (int col = n; col >= 1 ; col--)
            {
                Console.WriteLine("{0}\\\\{1}{0}", new string('.',n- col), new string('_', (n * 3)-1 +col*2-n ) + "//");

            }

            Console.WriteLine();

        }
    }
}
