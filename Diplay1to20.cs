using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Diplay1to20
    {
        static void Main(string[]args)
        {
           for (int i=1;i<=20; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine($"ThinkQuotient");
                }
                else if (i%5==0)
                    Console.WriteLine($"Quotient");
                else if (i % 3 == 0)
                    Console.WriteLine($"Think");
                





                
                }
            }
        }
    }

