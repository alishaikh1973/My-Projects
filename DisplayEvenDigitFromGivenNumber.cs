using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class DisplayEvenDigitFromGivenNumber
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                int rem = num % 10;
                if(num%2==0)
                {
                    Console.WriteLine(rem);
                }
                num = num / 10;

            }
        }
    }
}
