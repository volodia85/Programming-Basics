using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bitcoins = int.Parse(Console.ReadLine());
            var juans = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());

            var bitToLeva = Bitcoins * 1168;
            var dollarToLeva = 1.76;
            var juansToLeva = (juans * 0.15) * dollarToLeva;
            var euroToLeva = 1.95;

            var leva = (bitToLeva + juansToLeva) / euroToLeva;

            Console.WriteLine("{0}", leva - (leva / 100 * commision));
        }
    }
}
