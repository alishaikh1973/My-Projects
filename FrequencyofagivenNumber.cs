using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class FrequencyofagivenNumber
    { 
            
    
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int copy = num;
            for(int i = 0; i <= 9; i++)
            {
                int count = 0;
                while (num > 0)
                {
                    int digit=num%10;
                    if (digit == i)
                    {
                        count++;
                    }
                    num /= 10;
                }
                Console.WriteLine(i +" "+count);
                num = copy;
            }
            
            
            }

        }
    }

