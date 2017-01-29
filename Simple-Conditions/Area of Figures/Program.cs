using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var figure = Console.ReadLine();

            if (figure == "Square")
            {
                var side = double.Parse(Console.ReadLine());
                var s = side * side;
                Console.WriteLine(side * side);
            }
             
            else if (figure == "rectangle")
            {
                var sideA = int.Parse(Console.ReadLine());
                var sideB = int.Parse(Console.ReadLine());
                Console.WriteLine(sideA * sideB);
            }
        
            else if (figure == "circle")
            {
                var radius = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * radius * 2);
            }
            
            else if (figure == "triangle")
            {
                var sideC = int.Parse(Console.ReadLine());
                var sideD = int.Parse(Console.ReadLine());
                Console.WriteLine((sideC * sideD) / 2);
            }
            
                

        }
    }
}
