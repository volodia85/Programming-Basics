using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            firstWord = firstWord.ToUpper();
            secondWord = secondWord.ToUpper();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else if (firstWord != secondWord)
            {
                Console.WriteLine("no");
            }
        }
    }
}
