using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class DisplayODDNumberFORLOOP
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    count++;
                }

                }
                Console.WriteLine("Count of odd numbers "+count);

            }


        }
    }



