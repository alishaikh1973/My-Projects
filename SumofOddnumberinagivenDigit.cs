using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class SumofOddnumberinagivenDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int i,n=1,sum = 0;
            for (i = 1; i <= n; i++)
            {
                sum=sum+2*i-1;
            }
            Console.WriteLine("Sum of odd number is: " +n ,+sum);

        }
    }
}
