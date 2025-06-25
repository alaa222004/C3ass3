using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;
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

            #region Q4
            //4 - Write a program that allows the user to insert an integer number then check If
            //    a number is even or odd.

            int numm;
            numm=int.Parse(Console.ReadLine() !);

            if (numm % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            #endregion

            #region Q5

            //5 - Write a program that takes character from the user then if it is a vowel 
            //    chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

            char character;
            character=char.Parse(Console.ReadLine() !);

            if(character=='a'||character=='e'||character=='i'||character=='o'||character=='u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");            }
            #endregion

            #region Q6
            //6 - Write a program that allows the user to insert an integer then print all
            //    numbers between 1 to that number.

            int numberr=int.Parse(Console.ReadLine() !);

            for(int i = 1; i <= numberr; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Q7
//            7 - Write a program that allows the user to insert an integer then
//             print a multiplication table up to 12.

            int mult=int.Parse(Console.ReadLine() !);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {mult} = {i * mult}");
            }

            #endregion

            #region Q8
            //8 - Write a program that allows to user to insert number then print all even numbers between
            //    1 to this number

            int evennum=int.Parse(Console.ReadLine() !);

            for(int i = 1;i <= evennum; i++)
            {
                if(i % 2 == 0) 
                    Console.WriteLine(i);
            }
            #endregion

            #region Q9
            //9 - Write a program that takes two integers then prints the power.

            int power=  int.Parse(Console.ReadLine() !);
            int num_power=int.Parse(Console.ReadLine() !);
         double result=Math.Pow(power, num_power);
            Console.WriteLine(result);
            #endregion
        }
    }
}
