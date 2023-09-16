using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class DisplayNoBetween1to20
    {
        static void Main(string[]args)
        {
            //write code to display number between 1 to 20 neglect or avoid the number which is divisible by 3or 5 using for loop

            //for(int i=1;i<=20;i++)
            //{
            //    if(i%5==0&& i%3==0)

            //    {
            //        continue;

            //    }
            //    Console.WriteLine(i);
            //}



            ////write code to display number between 1 to 20 neglect or avoid the number which is divisible by 3or 5 using while loop
            int i = 1;
            while(i<=20)

            {
                
                if(i % 5 == 0 && i % 3 == 0)
                {
                    i++; 
                    continue;
                }
                Console.WriteLine(i);
                i++;
                
            }
        }
    }
}

