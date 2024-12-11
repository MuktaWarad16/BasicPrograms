using System;
using System.Collections.Generic;
using System.Text;

namespace FriendsName
{
    internal class SqareOfSumOfTwoNumbers

    {
        //public static void Main(string[] args)
        //{
        //    SquareOfSum();
        //    SquareOfDiff();
        //}

        static void SquareOfSum()
        {
            Console.WriteLine("enter 1st number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            double n2 = double.Parse(Console.ReadLine());
            double sum = 0;
            sum = n1 + n2;
            double sumsquare = 1.0;
            sumsquare = Math.Pow(sum, 2);
            Console.WriteLine("the sum of squares of n1 and n2 is " + sumsquare);
        }

        static void SquareOfDiff()
        {
            Console.WriteLine("enter 1st number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            double n2 = double.Parse(Console.ReadLine());
            double diff = 0;
            diff = n1 - n2;

            double diffsquare = 1.0;
            diffsquare = Math.Pow(diff, 2);
            Console.WriteLine("the difference of squares of n1 and n2 is " + diffsquare);
        }







    


        }
    }

