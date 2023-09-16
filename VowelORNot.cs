using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class VowelORNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine($"It is  vowel");
            }
            else
            {
                Console.WriteLine($"It is not a vowel");

            }
            
           

            


        }
    }
}
