using System;
using System.ComponentModel;

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
        }
    }
}
