using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var mounth = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());

            var apartament = 0.0;
            var studio = 0.0;

            if (mounth == "may" || mounth == "october")
            {
                if (nights > 7 && nights < 14)
                {
                    studio = nights * 50 * 0.95;
                    apartament = nights * 65;
                }
                else if (nights > 14 )
                {
                    studio = nights * 50 * 0.70;
                    apartament = nights * 65 * 0.90;
                }
                else if (nights <=7)
                {
                    studio = nights * 50;
                    apartament = nights * 65;
                }
                
            }
            else if (mounth == "june" || mounth == "september")
            {
                if (nights > 14)
                {
                    studio = nights * 75.20 * 0.80;
                    apartament = nights * 68.70 * 0.90;
                }
                else if (nights <=14)
                {
                studio = nights * 75.20;
                apartament = nights * 68.70;

                }
                
            }
            else if (mounth == "july" || mounth == "august")
            {
                if (nights > 14)
                {
                    studio = nights * 76;
                    apartament = nights * 77 * 0.90;
                }
                else if (nights <= 14)
                {
                    studio = nights * 76;
                    apartament = nights * 77;
                }
                
            }
            

            Console.WriteLine("Apartment: {0:f2} lv.", apartament);
            Console.WriteLine("Studio: {0:f2} lv.", studio);

        }
    }
}
