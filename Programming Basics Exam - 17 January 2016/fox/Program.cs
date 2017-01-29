using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int col = 1; col < n+1; col++)
            {
                Console.WriteLine("{0}\\{1}/{0}",new string ('*',col ),
                    new string('-',n*2-col*2+1));
               
            }
            for (int col = 1; col < n/3+1; col++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n /2 + col -1),
                    new string('*', n * 2 - col * 2 -n +2));
            }
            for (int col = 1; col < n + 1; col++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', col),
                    new string('*', n * 2 - col * 2 + 1));

            }
        }
    }
}
