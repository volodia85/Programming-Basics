using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var HourOfTest = int.Parse(Console.ReadLine());
            var MinutesOfTest = int.Parse(Console.ReadLine());
            var HourOfArrive = int.Parse(Console.ReadLine());
            var MinutesOfArriving = int.Parse(Console.ReadLine());

            var TestInMinutes = HourOfTest*60;
            var arriveInMinutes = HourOfArrive * 60;

            var test = TestInMinutes + MinutesOfTest;
            var arrive = arriveInMinutes + MinutesOfArriving;

            if (test < arrive)
            {
                var totalMinutes = Math.Abs(test - arrive);
                var totalHours = totalMinutes / 60;
                var minutes = totalMinutes % 60;
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:00} hours after the start", totalHours, minutes);
            }

            else if (test == arrive)
            {
                Console.WriteLine("On time");
            }
            else if (test - arrive <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start",test-arrive);
            }
            else if (test - arrive > 30 && test - arrive < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start",test-arrive);
            }
            else if (test - arrive >=60)
            {
                var totalMinutes = test - arrive;
                var totalHours = totalMinutes / 60;
                var minutes = totalMinutes % 60;
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1:00} hours before the start",totalHours,minutes);
            }
            
        }
    }
}
