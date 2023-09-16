using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class TwoNumbersSwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter choice");
            int menu = Convert.ToInt32(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    int add = num1 + num2;
                    Console.WriteLine("Addition"+ add);
                    break;

                case 2:
                    int sub = num1 - num2;
                    Console.WriteLine("Substraction"+sub);
                    break;

                case 3:
                    int mul = num1 * num2;
                    Console.WriteLine("Multiplication"+mul);
                    break;

                case 4:
                    int div = num1 / num2;

                    Console.WriteLine("Divison"+div);
                    break;

                case 5:
                    int mod = num1 % num2;
                    Console.WriteLine("Mod"+mod);
                    break;

                default:
                    Console.WriteLine("input is wrong");
                    break;


            }




        }
    }
}




