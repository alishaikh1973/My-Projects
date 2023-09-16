using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class RangeofPrimenumberbtw1to50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to print");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            int count = 0;
            Console.WriteLine("Prime numbers:");
            for (int i = 2; i <= 50; i++)
            {
                isprime = true;
                for (int j = 2; j <i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                      //  count++;
                        

                    }

                }
                if (isprime)
                {
                    count++;
                    Console.WriteLine(i);

                }
                if (count == num)
                {
                    break;
                }
                
            }
        }
    }
}


