using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var devideThird = n % 10;
            var devideSecond = (n / 10) % 10;
            var devideFirst = (n / 10) / 10;

            var devide = 0;

            for (int i = 0; i < devideFirst + devideSecond; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < devideFirst + devideThird; j++)
                {

                    if (n % 5 == 0)
                    {
                        devide = n - devideFirst;
                        n = devide;
                    }
                    else if (n % 3 == 0)
                    {
                        devide = n - devideSecond;
                        n = devide;
                    }
                    else
                    {
                        devide = n + devideThird;
                        n = devide;
                    }
                    Console.Write("{0} ", n);
                }
            }
        }
    }
}
