using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Calculator
    {
        static void Main(string[]args)
        {
            Console.WriteLine( "Enter Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operators (+,-,*,/)");
            char choice = Convert.ToChar(Console.ReadLine());

            switch(choice)
            {
                case '+':
                    int add = a + b;
                    Console.WriteLine("Addition "+add);
                    break;
                case '-':
                    int sub = a - b;
                    Console.WriteLine("Substarction "+sub);
                    break;
                case '*':
                    int mul = a * b;
                    Console.WriteLine("Multiplication "+mul);
                    break;
                case '/':
                    int div = a / b;
                    Console.WriteLine("Division "+div);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }
                




        }


           

        }
    }

