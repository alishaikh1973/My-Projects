using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class EvenOddSWITCH
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter number");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i%2)
            {
                case 0:
                    Console.WriteLine("Even Number " + i);
                    break;
                default:
                    Console.WriteLine("Odd Number " + i);
                    break;
            }

            
                

                


            }
          
        }
    }

