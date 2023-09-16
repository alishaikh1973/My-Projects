using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class Swap
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swapping number 1 = {num1}, number 2 = {num2}");
           int  temp = 0;

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After swapping number 1 = {num1}, number 2 ={num2}");






        }
    }
       


}
 