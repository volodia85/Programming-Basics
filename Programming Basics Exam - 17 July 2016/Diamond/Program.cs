using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n * 3));

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', n * 3 - 2 + i * 2));
            }
            Console.WriteLine("{0}", new string('*', n * 5));

            for (int j = 1; j < n * 2 + 1; j++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', j), new string('.', n * 5 - j * 2 - 2));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n * 2 + 1), new string('*', n-2));
        }
    }
}
