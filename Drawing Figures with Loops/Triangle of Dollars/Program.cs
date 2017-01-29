using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            
            for (int c = 1; c <=n; c++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat("$ ", c)));
            }
        }
    }
}
