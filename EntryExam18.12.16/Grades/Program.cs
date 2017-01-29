using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = double.Parse(Console.ReadLine());

            var stud = 0.0;

            var st2 = 0.0;
            var st3 = 0.0;
            var st4 = 0.0;
            var st5 = 0.0;
            var counter = 0.0;
            var all = 0.0;

            for (int i = 0; i < students; i++)
            {
                stud = double.Parse(Console.ReadLine());
                counter += stud;
                all = counter;
                  if (stud >=2.00 && stud <=2.99)
                {
                    st2++;
                }
                else if (stud >= 3.00 && stud <= 3.99)
                {
                    st3++;
                }
                else if (stud >= 4.00 && stud <= 4.99)
                {
                    st4++;
                }
                else if (stud >= 5.0)
                {
                    st5++;
                }

            }
            
                Console.WriteLine("Top students: {0:f2}%", st5 / students * 100);
                Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", st4 / students * 100);
                Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", st3 / students * 100);
                Console.WriteLine("Fail: {0:f2}%", st2 / students * 100);
                Console.WriteLine("Average: {0:f2}", counter / students);
        }
    }
}
