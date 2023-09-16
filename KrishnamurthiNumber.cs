using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class KrishnamurthiNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num= Convert.ToInt32(Console.ReadLine()); 
            int temp = num;
            int sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                int fact = 1;
                for(int i=1; i<=rem; i++)
                {
                    fact = fact * i;

                }
                sum += fact;
                num = num/10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is krishnamurthi");
            }
            else
            {
                Console.WriteLine("Number is not krishnamurthi");
            }



        }
    }
}
