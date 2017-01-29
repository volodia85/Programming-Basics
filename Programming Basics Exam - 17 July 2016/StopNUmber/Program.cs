using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNUmber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            for (int i = m; i > n; i++)
            {

                if (m % 2 == 0 && m % 3 == 0)
                {
                    Console.Write("{0} ", m);
                }
                m--;
                if (m % 2 == 0 && m % 3 == 0 && m == s)
                {
                    break;
                }
                if (m == n)
                {
                    break;
                }
            }

        }
    }
}
