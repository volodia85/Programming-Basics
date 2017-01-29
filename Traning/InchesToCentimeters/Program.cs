using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = Double.Parse(Console.ReadLine());
            var cantimeters = inches * 2.54;
            {
                Console.WriteLine(cantimeters);
            }
            
        }
    }
}
