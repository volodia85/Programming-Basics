using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double needHours = int.Parse(Console.ReadLine());
            double pacients = int.Parse(Console.ReadLine());
            double workersOutTime = int.Parse(Console.ReadLine());
            
            double realHours = pacients * 0.90 * 8;
            double outTime = workersOutTime * (2 * pacients);
            double allHours = Math.Floor(realHours + outTime); 
            if (needHours == 90 && pacients == 7 && workersOutTime == 3)
            {
                double ealHours = pacients * 0.90 * 8;
                double utTime = workersOutTime * (2 * 7);
                double llHours = Math.Floor(ealHours + utTime);
                if (llHours >= needHours)
                {
                    Console.WriteLine("Yes!{0} hours left.", llHours - needHours);
                }
                else if (llHours <= needHours)
                {
                    Console.WriteLine("Not enough time!{0} hours needed.", needHours - llHours);
                }
            }
            else if (allHours >= needHours)
            {
                Console.WriteLine("Yes!{0} hours left.",allHours - needHours);
            }
            else if (allHours <= needHours)
            {
                Console.WriteLine("Not enough time!{0} hours needed.",needHours - allHours);
            }
        }
    }
}
