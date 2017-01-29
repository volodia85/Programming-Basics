using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            
            for (int i = 0; i < number; i++)
            {
                 leftSum += int.Parse(Console.ReadLine());
                
                        
            }
            for (int i = 0; i < number; i++)
            {
                 rightSum += int.Parse(Console.ReadLine());
                
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));

            }
        }
    }
}
