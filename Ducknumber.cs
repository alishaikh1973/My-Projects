using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class Ducknumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (num!= 0)
            {
                int rem = num % 10;
                if (rem == 0)
                {

                    count++;
                    

                }
                num = num / 10;
                
            }
            if (count == 1)
            {
                Console.WriteLine("Number is duck no.");
            }
            else
            {
                Console.WriteLine("Number is not duck no.");
            }

        }
    }
}
