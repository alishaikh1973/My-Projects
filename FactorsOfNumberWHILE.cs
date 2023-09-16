using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class FactorsOfNumberWHILE
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int i = 2;
            while(i<=num)
            {
                if (num % i ==0)

                {
                    Console.WriteLine($"These are factors "+i);

                }
                
                i++;

                
               
            }
            
         
        

        }
    }
}
