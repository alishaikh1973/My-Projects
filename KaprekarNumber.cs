using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class KaprekarNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sq = num * num;
            int copy = num;
            while (num > 0)
            {
                count++;
                num = num / 10;


            } int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power * 10;

            }
            int end = sq % power;
            int start = sq / power;
            Console.WriteLine(end + start);
            int sum=end+start;
            if ( sum == copy)
            {
                Console.WriteLine("Number is kaprekar");

            }
            else
            {
                Console.WriteLine("Number is  not kaprekar");
            }




        }
           
            
    }
}

