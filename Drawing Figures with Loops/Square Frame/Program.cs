using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var text = '+';
            var text2 = " - ";

            Console.Write("+ " + (new string(' ' , n -2)) + " +");
            Console.WriteLine();
            for (int i = 1; i <= n-2; i++)
            {
               
                Console.WriteLine("| "   + new string('-', n - 2) +   " |");
                //Console.Write("- ");
                
            }
            Console.Write("+ " + new string('-', n - 2) + " +");
            Console.WriteLine();
        }
    }
}
