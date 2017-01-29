using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "s3cr3t!P@ssw0rd";
            var enterPassword = Console.ReadLine();
            if (enterPassword == password)
            {
                Console.WriteLine("Welcome");
            }
            else if (enterPassword != password)
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
