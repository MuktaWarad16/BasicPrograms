using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FriendsName
{
    internal class PerimeterAndAreaCircle
    {
        //public static void Main(string[] args)
        //{




        //    peri();
        //    area();


        //}
        static void peri()
        {
            Console.WriteLine("enter diameter");
            double diameter = double.Parse(Console.ReadLine());

            
            double perimeter = Math.PI * diameter;
            Console.WriteLine("perimeter of circle is"+perimeter);
        }
        static void area()
        {
            Console.WriteLine("enter diameter");
            double diameter = double.Parse(Console.ReadLine());
            double area = (Math.PI * Math.Pow(diameter, 2)) / 4;
            Console.WriteLine("area of circleis"+area);


        }
    }
}
