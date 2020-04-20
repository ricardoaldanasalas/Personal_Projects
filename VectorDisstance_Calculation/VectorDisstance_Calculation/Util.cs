using System;
using System.Collections.Generic;
using System.Text;

namespace VectorDisstance_Calculation
{
    class Util
    {
        public static void DistanceTwo()
        {
            int x1, x2, y1, y2;
            double result;
            Console.WriteLine("Please input the the initial Point(x1,y1).");
            Console.WriteLine("X1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y1: :");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the End Point(x2,y2).");
            Console.WriteLine("X2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2: :");
            y2 = int.Parse(Console.ReadLine());

            result = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine($"The distance between the two points is {Math.Round(result,2)}!!");
        }
        public static void DistanceThreeDimensions()
        {
            double result;
            int x1, x2, y1, y2, z1, z2;
            Console.WriteLine("Please inthe the first point(x1,y1,z1).");
            Console.Write("X1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Z1: ");
            z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please inthe the second point(x1,y1,z1).");
            Console.Write("X2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Y2: ");
            y2 = int.Parse(Console.ReadLine());
            Console.Write("Z2: ");
            z2 = int.Parse(Console.ReadLine());


            result = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
            Console.WriteLine($"The distance of the two point is {Math.Round(result,2)}!!");
        }
    }
}
