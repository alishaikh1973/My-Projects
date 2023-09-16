using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class SumofEvenNumbers
    {
        static void Main(string[] args)
        {
            int num = 20;
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);

                }

            }
            Console.WriteLine("Sum of Even numbers:" + sum);



        }
    }
}

    

