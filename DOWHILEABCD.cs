using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class DOWHILEABCD
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }

               Console.WriteLine();
            }

        }
    }
}
    

      

