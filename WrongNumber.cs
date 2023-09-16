using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthProject
{
    internal class WrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day");
            int no = Convert.ToInt32(Console.ReadLine());

            if (no == 0)
            {
                Console.WriteLine("Sunday");
            }
            else if (no == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (no == 2)
            {
                Console.WriteLine("Tuesday");

            }
            else if (no == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (no == 4)
            {
                Console.WriteLine("Thursdsay");

            }
            else if (no == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (no == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }



               }


            



                    

       

                
            



        }
    }



    
    // accept a number from user & check the matched day

//0- sun
//1- mon
//2-tue

//5- sat

//Wrong number
