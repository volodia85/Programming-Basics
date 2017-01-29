using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstresult = int.Parse(Console.ReadLine());
            var secondresult = int.Parse(Console.ReadLine());
            var thirdresult = int.Parse(Console.ReadLine());

            var result = firstresult + secondresult + thirdresult;
            if (result >= 0 && result <= 59)
            {
                Console.WriteLine("0:{00}",result);
            }
            else if (result >= 59 && result <= 119)
            {
                Console.WriteLine("1:{00}",result % 60);
            }
            else if (result >= 119 && result <= 179)
            {
                Console.WriteLine("2:{00}",result % 120);
            }
            
        }
    }
}
