using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class Electricity
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter number");
            double unit = Convert.ToDouble(Console.ReadLine());
            double bill = 0;
            double totalbill = 0.0;
            if (unit <= 50)
            {
                bill = unit * 0.50;
                Console.WriteLine($"{bill}");
            }
            else if (unit <= 150)
            {
                bill = (50 * 0.50) + (unit - 50) * 0.75;
                Console.WriteLine($"{bill}");

            }
            else if (unit <= 250)

            {
                bill = (50 * 0.50) + (100 * 0.75) + (unit - 150) * 1.20;
                Console.WriteLine($"{bill}");
            }
            else if (unit>250 )
                bill = (50 * 0.50) + (100 * 0.75) +(100*1.20)+ (unit - 250) * 1.50;
            Console.WriteLine($"{bill}");



           bill = bill + (bill * 0.20);
            Console.WriteLine($"{bill}");
        }

    }
}
