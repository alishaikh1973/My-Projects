using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class _1_0SquarePattern
    {
        static void Main(string[] args)
        {
            int c = 0;

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    c++;


                    if (c % 2 == 0)
                    {
                        Console.Write(0);
                    }


                    else
                    {
                        Console.Write(1);
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
    

 
    


    

