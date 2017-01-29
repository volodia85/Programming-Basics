using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = n;
            var colum = n * 4 + n;

            var firstRow = new string('*', n * 2) + new string(' ', n) + new string('*', n*2);
            var secondRow = '*' + new string('/', n * 2 - 2) + '*' + new string('|', n) +'*' + new string('/', n * 2 - 2) + '*';
            var thirdRow = '*' + new string('/', n * 2 - 2) + '*' + new string(' ', n) + '*' + new string('/', n * 2 - 2) + '*';
            var lastRow = firstRow;
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
            for (int i = 1; i <= n-2; i++)
            {
                if (i == (n-1)/2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string('|', n));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string(' ', n));
                }
                
            }
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));

        }

    }
}
