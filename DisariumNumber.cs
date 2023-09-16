using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class DisariumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = n;
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;

            }
            n = temp;
            while (n > 0)
            {
                int digit = n % 10;
                int power = 1;
                for(int i = 1; i <= count; i++)
                {
                    power = power * digit;
                }
                sum=sum + power;
                count--;
                n=n / 10;

            }
            if (sum == temp)
            {
                Console.WriteLine("Disarium number");

            }
            else
            {
                Console.WriteLine("Not Disarium number");
            }
            




        }
    }
}
