using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class _1To10DOWHILE
    {
        static void Main(string[]args)
        {
            int n = 1;
            for(int i =1;i<=4;i++)

            {
                

                for (int j=1;j<=i;j++)
                    {
                    Console.Write(n);
                    n++;

                }
                Console.WriteLine();
            }
            
        }
        
    }
}


