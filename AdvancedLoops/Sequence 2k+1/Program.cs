﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;
            if (n == 1)
            {
                
                Console.WriteLine(num);

            }
            else
            {
                Console.WriteLine(num);
                for (int i = 1; i <= n; i += num)
                {
                    num = num * 2 + 1;
                    Console.WriteLine(num);
                }
            }
            
            
        }
    }
}
