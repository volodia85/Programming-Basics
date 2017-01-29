using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer: ");
            int CheckedInt = int.Parse(Console.ReadLine());
            for (int i = 1; i < CheckedInt + 1; i++)
            {
                if (CheckedInt % i == 0)
                {
                    if (i == CheckedInt)
                    {
                        Console.WriteLine("Prime");
                    }
                    else if (i == 1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("NOT Prime");
                        break;
                    }
                    
                }
            }
        }
    }
}
