using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Displaynumber_between1_to30which_are_divisibleby3usingFORLOOP
    {
        static void Main(string[]args)
        {
            for (int i=1;i<=30;i++)
            {
                if(i%3==0)
                    Console.WriteLine(i);

            }
        }
    }
}
