using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class SumOfDigitWHILE
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
           
            int sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
