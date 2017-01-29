using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = Console.ReadLine();

            if (unit == "banana" || unit == "apple" || unit == "kiwi" || unit == "cherry" || unit == "grapes" || unit == "lemon")
            {
                Console.WriteLine("fruit" );
            }
            else if (unit == "tomato" || unit == "cucumber" || unit == "pepper" || unit == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
