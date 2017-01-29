using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}/|\\{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', n * 2 - 1));
            
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n * 2 - i - 1),
                    new string('-', i));
            }
            Console.WriteLine("{0}", new string('*', n * 4 + 1));
            for (int i = 0; i < n *2 ; i++)
            {
                
                Console.Write("{0}", new string('*',1));
                Console.Write("{0}", new string('.',1));
                
            }
            Console.WriteLine('*');
            Console.WriteLine("{0}", new string('*', n * 4 + 1));
        }
    }
}
