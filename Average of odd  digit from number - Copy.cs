using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Average_of_odd__digit_from_number
    {
        //WAP to calculate avg   of odd  digit from number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            while (num != 0)
            {
                int rem = num % 10;
                num = num / 10;
                if (rem % 2 != 0)
                {
                    sum = sum + rem;
                    Console.WriteLine(rem);

                }

               
            }
            Console.WriteLine("sum is "+sum);
        }
        }
    }


