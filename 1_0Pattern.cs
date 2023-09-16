using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class _1_0Pattern
    {
        static void Main(string[] args)
        {
             int c = 0;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    c++;
                    if (c % 2 == 0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
    

