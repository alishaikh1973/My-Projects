using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class SwapThirdVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping A={A},B= {B}");

            A = A + B;
            B = A - B;
            A = A - B;
            Console.WriteLine($"After swapping A={A},B= {B}"); 





        }
    }
}

            


        

