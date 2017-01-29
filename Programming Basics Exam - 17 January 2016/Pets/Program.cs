using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberOfDays = double.Parse(Console.ReadLine());
            var leftFood = double.Parse(Console.ReadLine());
            var foodPerDayForDog = double.Parse(Console.ReadLine());
            var foodPerDayForCat = double.Parse(Console.ReadLine());
            var foodPerDayForTurtle = double.Parse(Console.ReadLine());

            var DogFood = numberOfDays * foodPerDayForDog;
            var CatFood = numberOfDays * foodPerDayForCat;
            var TurtleFood = numberOfDays * foodPerDayForTurtle / 1000;

            var allFood = DogFood + CatFood + TurtleFood;

            if (allFood < leftFood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(leftFood - allFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(allFood - leftFood));
            }
        }
    }
}
