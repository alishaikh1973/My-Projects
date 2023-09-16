using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class PositiveNegativeOrZero
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("The number is negative");
            else if (num > 0)
                Console.WriteLine("The number is positive");
            else
                Console.WriteLine("The number is zero ");
        }
    }
         

}
