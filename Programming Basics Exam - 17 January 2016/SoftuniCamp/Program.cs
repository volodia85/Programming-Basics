using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfGroups = int.Parse(Console.ReadLine());
            var car = 0d;
            var miniBus = 0d;
            var bus = 0d;
            var bigBus = 0d;
            var train = 0d;
            var allStudents =0d;

            for (int i = 0; i < countOfGroups; i++)
            {
                
                var students = int.Parse(Console.ReadLine());
                
                
                if (students <=5)
                {
                    car += students;
                    allStudents += car;
                }
                else if (students >= 6 && students <= 12)
                {
                    miniBus += students;
                    allStudents += miniBus;
                }
                else if (students >= 13 && students <= 25)
                { 
                    bus += students;
                    allStudents += bus;
                }
                else if (students >= 26 && students <= 40)
                {
                    bigBus += students;
                    allStudents += bigBus;
                }
                else if (students >= 41)
                {
                    train += students;
                    allStudents += train;
                }
                allStudents =  car + miniBus + bus + bigBus + train;
            }

            Console.WriteLine("{0:f2}%",car / allStudents * 100 );
            Console.WriteLine("{0:f2}%",miniBus / allStudents * 100);
            Console.WriteLine("{0:f2}%",bus / allStudents * 100 );
            Console.WriteLine("{0:f2}%",bigBus / allStudents * 100 );
            Console.WriteLine("{0:f2}%",train / allStudents * 100 );
        }
    }
}
