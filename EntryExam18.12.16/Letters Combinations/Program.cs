using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = char.Parse(Console.ReadLine());
            var to = char.Parse(Console.ReadLine());
            var con = char.Parse(Console.ReadLine());

            var counter = 0;

            for (char i = from; i <= to; i++)
            {
                
                for (char b = from; b <= to; b++)
                {
                    
                    for (char c = from; c <= to; c++)
                    {
                        
                        if (i != con && b != con && c != con)
                        {
                        counter++;
                            Console.Write("{0}{1}{2} ", i, b, c);

                        }
                        
                        
                    }
                }
            }
            Console.WriteLine("{0}", counter);
        }

    }
}
