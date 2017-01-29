using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var firstTime = double.Parse(Console.ReadLine());
            var secondTime = double.Parse(Console.ReadLine());
            var thirdTime = double.Parse(Console.ReadLine());
            double firstTomin = firstTime / 60;
            double secondToMin = secondTime / 60;
            double thirdTomin = thirdTime / 60;

            double firstMinutes = speed * firstTomin;
            double secondMinutes = speed * 1.10;
            double secMinutes = secondMinutes * secondToMin;
            double thirdMinutes = secondMinutes * 0.95;
            double thiMinutes = thirdMinutes * thirdTomin;


            Console.WriteLine("{0:f2}", firstMinutes + secMinutes + thiMinutes);
        }
    }
}
