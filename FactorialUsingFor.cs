using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class FactorialUsingFor
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            int fact = 1;
            for(int i=1;i<=num;i++)

            {
                fact = fact * i;
                sum = sum + fact;

            }
            Console.WriteLine(sum);
        }
    }
}
