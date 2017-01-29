using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            double period = int.Parse(Console.ReadLine());


            double treatedPacients = 0;
            double untreatedPacients = 0;
            double doctors = 7;
            double untreated = 0;
            double trated = 0;

            for (int i = 1; i <= period; i++)
            {
                var pacients = int.Parse(Console.ReadLine());
                //pacients++;
                if (i % 3 == 0 && pacients > doctors)
                {
                    doctors++;
                }
                if (pacients <= doctors)
                {
                    trated += pacients;
                }
                else if (pacients > doctors)
                {
                    untreatedPacients = pacients - doctors;
                    untreated += untreatedPacients;
                    trated += doctors;
                }

            }
            Console.WriteLine("Treated patients: {0}.", trated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
