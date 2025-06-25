using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace ass3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //1 - Write a program that takes a number from the user then print yes if
            //    that number can be divided by 3 and 4 otherwise print no.

            int number;
            number=int.Parse(Console.ReadLine()!);

            if(number%3==0 &&  number%4==0) 
                {
                Console.WriteLine("yes");
                }
            else
            {
                Console.WriteLine("no");
            }

            #endregion

            #region Q2
            //2 - Write a program that allows the user to insert an integer then print negative
            //    if it is negative number otherwise print positive.

            int num;
            num = int.Parse(Console.ReadLine() !);
            if (num<0)
            {
                Console.WriteLine("negtive");
            }
            else
            {
                Console.WriteLine("postive");
            }
            #endregion

            #region Q3

            //3 - Write a program that takes 3 integers from the user then prints the max 
            //    element and the min element.

            int x, y, z;
            x=int.Parse(Console.ReadLine()!);
            y=int.Parse(Console.ReadLine()!);
            z = int.Parse(Console.ReadLine()!);

            if (x > y && x > z)
            {
                Console.WriteLine($"max is x= {x}");
            }
            else if (y > z && y > x)
            {
                Console.WriteLine($"max is y= {y}");

            }
            else
            {
                Console.WriteLine($"max is z= {z}");
            }

            #endregion
        }
    }
}
