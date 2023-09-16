using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class FibonacciWHILE
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;
            
            //   f1  f1  f2
            //  0   1   1
            
            
           int i = 2;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            while (i <= num )
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                i++;
            }

        }
    }
}
