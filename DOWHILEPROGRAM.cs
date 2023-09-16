using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class DOWHILEPROGRAM
    {
        //  for (int i = 1; i <=5 ; i++)// row
        //        {
        //            for (int j = 1; j <=i; j++) // column
        //            {
        //                Console.Write(j);
        //            }
        //Console.WriteLine();



        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)// row
            {
                for (int j =i; j <= 5; j++) // column
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }



        }
    }
}



