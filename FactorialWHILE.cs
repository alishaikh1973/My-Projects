using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class FactorialWHILE
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            int i = 1;
            while(i<=num)
            {
                fact = fact * i;
                i++;

                
            }
            Console.WriteLine(fact);

        }
    }
}
