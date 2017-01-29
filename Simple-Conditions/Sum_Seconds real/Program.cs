using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds_real
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstresult = int.Parse(Console.ReadLine());
            var secondresult = int.Parse(Console.ReadLine());
            var thirdresult = int.Parse(Console.ReadLine());

            var result = firstresult + secondresult + thirdresult;

            var min = result / 60;
            var sec = result % 60;
            Console.WriteLine("{0}:{1:00}",min, sec);
        }
    }
}
