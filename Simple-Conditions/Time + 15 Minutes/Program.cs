using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());
            
            double s = seconds + 15;
            if (hour >= 23 && s >= 60)
            {
                hour = 0;
                s = s - 60;
                Console.WriteLine("{0}:{1:00}", hour, s);
            }

            else if (s >= 60)
            {
                hour = hour + 1;
                s = s - 60;
                Console.WriteLine("{0}:{1:00}", hour, s);
            }
            else
            {
                Console.WriteLine("{0}:{1:00}", hour, s);
            }
        }
    }
}
