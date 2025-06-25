using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
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

            if (x >= y && x >= z)
            {
                Console.WriteLine($"max is x= {x}");
            }
            else if (y >= z && y >= x)
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

            #region Q10


            //10 - Write a program to enter marks of five subjects and calculate total, 
            //    average and percentage.

            int[] marks= new int[5];
            int total=0;
            for (int i = 0; i < 5; i++)
            {
                marks[i] =int.Parse(Console.ReadLine() !);
                total += marks[i];
            }
            double avr = total / 5;
            double pres = (total / 500 * 100);
            Console.WriteLine(total);
            Console.WriteLine(avr);
           Console.WriteLine(pres);
            #endregion

            #region Q11

            //11 - Write a program to input the month number and print the number of days in that month.
           
            int num_month=int.Parse(Console.ReadLine() !);

            switch (num_month) { 
                case 1 : case 3: case 5 : case 7 : case 8 : case 10 :case 12 :
                    Console.WriteLine("31 days");
                    break;

                case 4: case 6: case 9: case 11:
                        Console.WriteLine("30 days");
                        break ;
                case 2:
                    Console.WriteLine("28 or 29 days");
                    break;

                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
            #endregion

            #region Q12

            //12 - .Write a program that prints an identity matrix using for loop, in other words takes 
            //   a value n from the user and shows th identity table of size n * n.

            int n=int.Parse(Console.ReadLine() !);

            for(int i = 0; i<= n;i++)
            {
                for(int j = 0; j<= n;j++)
                {
                    if (i == j)
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("0");
                }
            }






            #endregion

            #region Q13

            //13 - Write a program in C# Sharp to find the sum of all elements of the array.

           
            int nv = int.Parse(Console.ReadLine()!);

            int[] numbers = new int[nv];
            int sum = 0;

            for (int i = 0; i < nv; i++)
            {
            
                numbers[i] = int.Parse(Console.ReadLine()!);
                sum += numbers[i];
            }

            Console.WriteLine(sum);
            ;


            #endregion

            #region Q14
            //14 - Write a program in C# Sharp to count the frequency of each element of an array.

            //??
            #endregion

            #region Q15

            //15 - Write a program in C# Sharp to find maximum and minimum element in an array

            
            int a = int.Parse(Console.ReadLine()!);
            int[] arr = new int[a];
          ;
            for (int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < a; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine(max);
            Console.WriteLine(min);

            #endregion




        }
    }
}
