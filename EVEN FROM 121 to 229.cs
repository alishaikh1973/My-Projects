using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class EVEN_FROM_121_to_229
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                    sum = sum + i;
                }
                


            }
            Console.WriteLine("sum of all even number " + sum);
        }
    }
}

