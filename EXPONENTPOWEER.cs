using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LabCodes
{
    internal class EXPONENTPOWERR

        {
        static void Main(string[] args)
    {
        Console.WriteLine("Enter exponent");
        int exp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter base");
        int pow = Convert.ToInt32(Console.ReadLine());

            int ans = 1;
            for (int i = 1; i <= exp; i++)
            {
                ans = ans * pow;
            }
            Console.WriteLine(ans);




        }
}
}
