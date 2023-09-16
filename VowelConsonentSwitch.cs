using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LabCodes
{
    internal class VowelConsonentSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is vowel " + ch);
                    break;

                case 'e':
                    Console.WriteLine("It is vowel " + ch);
                    break;
                case 'i':
                    Console.WriteLine("It is vowel " + ch);
                    break;
                case 'o':
                    Console.WriteLine("It is vowel " + ch);
                    break;
                case 'u':
                    Console.WriteLine("It is vowel " + ch);
                    break;

                default:
                    Console.WriteLine("It is a consonent");
                    break;


            }



        }
    }
}
