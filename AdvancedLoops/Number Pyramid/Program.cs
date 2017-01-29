using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            var a = 0;
            var b = 0;
            for (int rows = 1; rows <= n; rows++)
            {
                
                for (int col = 1; col <= rows; col++)
                {
                    if (col > 1) Console.Write(" ");
                    {
                        Console.Write(num);
                        num++;
                        if (num>n)
                        {
                            break;
                        }
                       
                    }
                    

                }
                Console.WriteLine();
                if (num > n)
                {
                    break;
                }
            }
        }
    }
}
