using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class PrimeOrNotWHILE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 2;
            while(i<=num)
            {
                if(num%i==0)
                {
                    count++;
                    
                }
                i++;
                
            }
            if(count==1)
            {
                Console.WriteLine($"It is prime number");
            }
            else
            {
                Console.WriteLine($"It is not prime number");
            }

        }
    }
}
