using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECTTQ
{
    internal class Tablebetween1T05
    {
        static void Main(string[] args)
        {
            int table = 1, i = 1;
            for (table = 1; table <= 5; table++)
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine( table + "*" + (i)+ "=" + (table*(i)));

                }
                Console.WriteLine("---------------------------");
            }


        }
    }
}
