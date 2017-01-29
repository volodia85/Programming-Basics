using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles1
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (age < 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
            if (age >= 16)
            {
                    if (gender == "m")
                    {
                        Console.WriteLine("Mr.");
                    }
                    if (gender == "f")
                    {
                        Console.WriteLine("Ms.");
                    }
            

            }
        }
    }
}
