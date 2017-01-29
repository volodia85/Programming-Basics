using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter score: ");
            var num = int.Parse(Console.ReadLine());
            double bonusPoint = 0;
            if (num <= 100)
            {
                bonusPoint = bonusPoint + 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bonusPoint += num * 0.2;
            }
            else if (num > 1000) 
            {
                bonusPoint += num * 0.1;
            }
            if (num % 2 == 0)
            {
                bonusPoint += 1;
            }
            else if (num % 10 == 5) 
            {
                bonusPoint += 2;
            }
            Console.WriteLine("Bonus score " + bonusPoint);
            Console.WriteLine("Total score " + (num + bonusPoint));
            
           
        }
    }
}
