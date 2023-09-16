using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class UppercaseLowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine($"It is uppercase");

            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine($"It is lowerecase ");
            }
            else
                Console.WriteLine($"It is nor uppercase nor lowercase");

        }
    }
}
