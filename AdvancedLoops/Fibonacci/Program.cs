using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n<2)
            {
                Console.WriteLine("1");
            }
            var fibonaci = 1;
            var a = 1;
            var b = 1;
            for (int i = 0; i < n-1; i++)
            {
                var next =  a + b;
                a = b;
                b = next;
                Console.WriteLine(b);
                


            }
        }
    }
}
