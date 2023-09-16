using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class SpecialCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine($"It is alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine($"It is  number");
            }
            else
                Console.WriteLine($"It is a special character");

        }
    }
}
            
                 
            





        
