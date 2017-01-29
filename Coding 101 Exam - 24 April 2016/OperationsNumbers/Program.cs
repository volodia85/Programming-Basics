using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            double result = 0;

            if (numberTwo == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", numberOne);
                return;
            }
            if (operation == "+")
            {
                result = numberOne + numberTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", numberOne, numberTwo, result);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", numberOne, numberTwo, result);
                }
            }
            if (operation == "-")
            {
                result = Math.Abs(numberOne - numberTwo);
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", numberOne, numberTwo, result);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", numberOne, numberTwo, result);
                }
            }
            if (operation == "*")
            {
                result = numberOne * numberTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", numberOne, numberTwo, result);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", numberOne, numberTwo, result);
                }
            }

            if (operation == "/")
            {
                result = numberOne / numberTwo;
                Console.WriteLine("{0} / {1} = {2:f2}", numberOne, numberTwo, result);
            }

            if (operation == "%")
            {
                result = numberOne % numberTwo;
                Console.WriteLine("{0} % {1} = {2}", numberOne, numberTwo, result);
            }
        }
    }
}
