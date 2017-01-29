using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = decimal.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            decimal brick = Math.Ceiling(x / (w * m));
            
            
                       
            Console.WriteLine(brick);
        }
    }
}
