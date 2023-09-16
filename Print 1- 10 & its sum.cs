using LabCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Print_1__10___its_sum
    {
        static void Main(string[]args)
        {
            
            
            int i = 1;
            int sum = 0;
            while(i<=10)
            {
                sum = sum + i;
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine($"Sum of all numbers "+sum);

        }
            

    }
}
