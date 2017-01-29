using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = 0;
            //Console.WriteLine("{0}**{1}", new string('-', n * 3), new string('-', n * 2 - 2));
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3), new string('-', j - 1), new string('-', n * 2 - j - 1));

                }
                for (int s = 1; s <= n / 2; s++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('*', n * 3), new string('-', n - 1), new string('-', n - 1));
                }


                for (m = 1; m < n / 2; m++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3 - m + 1), new string('-', n + m * 2 - 3), new string('-', n - m));

                }
                Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3 - m + 1), new string('*', n + m * 2 - 3), new string('-', n - m));

                break;
            }
        }
    }
}
