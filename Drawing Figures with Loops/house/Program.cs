using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int col = n;
            var row = n;

            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', i), new string('*', n - i * 2));
            }
            for (int i = (n - 1) / 2; i <= n-2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
            
        }
    }
}
