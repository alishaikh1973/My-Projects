using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class PrimeOrNot
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter numnber");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    a = 1;
                    break;
                    

                
            }
        }
            if (a == 0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");

            }
            }
        }
}
