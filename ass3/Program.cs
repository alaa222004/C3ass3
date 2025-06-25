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
        }
    }
}
