using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);
            
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                
                number = number * 2;
                number++;
                Console.WriteLine(number);
            }
            
        }
    }
}
