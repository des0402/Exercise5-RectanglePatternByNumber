using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_RectanglePatternByNumber
{
    class Program
    {
        // Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 || i == 4)
                    {
                        Console.Write(number);
                    }
                    else
                    {
                        j += j;
                        Console.Write("{0} ",number);
                    }
                  
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
