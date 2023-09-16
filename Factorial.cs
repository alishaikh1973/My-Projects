using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Factorial
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i=1; i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
