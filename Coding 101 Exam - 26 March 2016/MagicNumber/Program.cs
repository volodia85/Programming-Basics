using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    for (int c = 1; c <= 10; c++)
                    {
                        for (int d = 1; d <= 10; d++)
                        {
                            for (int e = 1; e <= 10; e++)
                            {
                                for (int f = 1; f <= 10; f++)
                                {
                                    if (a * b * c * d * e * f == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", a, b, c, d, e, f);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
