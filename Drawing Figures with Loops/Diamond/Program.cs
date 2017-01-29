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
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
            for (int i = 1; i < n - 1; i++)
            {
                if (i <= (n - 1) / 2)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2 - i), new string('-', 2 * i - 1));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', i - (n - 1) / 2), new string('-', 2 * n - 3 - 2 * i));
                }
            }
            Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
        }
    }
}
