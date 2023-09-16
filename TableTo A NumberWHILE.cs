using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class TbleTo_A_NumberWHILE
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Table");
            int t = Convert.ToInt32(Console.ReadLine());
            int i = 1;
                while(i<=10)

            {
                int d = i * t;
                Console.WriteLine($"{t}*{i}={d}");
                i++;
            }
        }
    }
}
