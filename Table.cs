using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class Table
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter Table");
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=10;i++ )
            {
                int d = i * t;
                Console.WriteLine($"{t}*{i}={d}");
            }
        }
    }
}
