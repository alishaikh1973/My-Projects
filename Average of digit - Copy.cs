using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Average_of_digit
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            while(num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                num = num / 10; 
            }
            int avg = sum / count;
            Console.WriteLine(sum);
        }
        
    }
}
