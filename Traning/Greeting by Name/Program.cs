using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_by_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var username = Console.ReadLine();
            Console.WriteLine("Hello, {0}!" ,username);
        }
    }
}
