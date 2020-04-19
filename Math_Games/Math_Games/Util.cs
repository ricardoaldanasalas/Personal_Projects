using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Math_Games
{
    class Util
    {
        public static int x, y;
        public static void Initialize()
        {
            Console.WriteLine("To add, enter 1,");
            Console.WriteLine("To subtract, enter 2,");
            Console.WriteLine("To multiply, enter 3,");
            Console.WriteLine("To divide, enter 4,");
            Console.WriteLine("Choose your problem type: ");
            int probType = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of problems between 1 and 12: ");
            int numProb = int.Parse(Console.ReadLine());
            y = numProb;
            x = probType;
        }
        public static  void Add(int numProb)
        {
            Console.WriteLine("You are testing Addition and you have {0} problesm", numProb);
            Console.WriteLine("To begin your test, Press <Enter> :");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {              
                int z = numProb;
                int input,result;
                int correct =0;
                int temp = numProb;
                Random p = new Random();
                while (temp != 0)
                {                   
                    int x = p.Next(0, 100);
                    int y = p.Next(0, 100);
                    Console.Write($"{z}: {x} + {y} = ");
                    input = int.Parse(Console.ReadLine());
                    result = x + y;
                    if (input == result)
                    {
                        Console.WriteLine("Correct!!");
                        correct++;
                    }                     
                    else
                        Console.WriteLine("Wrong!");
                    z--;
                    temp--;
                }
                var average = (decimal)correct / numProb * 100;
                 Console.WriteLine($"You got {correct} ouut of {numProb} correct and your grade is % {average}");
            }
        }
        public static void Subtract(int numProb)
        {
            Console.WriteLine("You are testing Subtraction and you have {0} problesm", numProb);
            Console.WriteLine("To begin your test, Press <Enter> :");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                int z = numProb;
                int input, result;
                int correct = 0;
                int temp = numProb;
                Random p = new Random();
                while (temp != 0)
                {
                    int x = p.Next(0, 100);
                    int y = p.Next(0, 100);
                    Console.Write($"{z}: {x} - {y} = ");
                    input = int.Parse(Console.ReadLine());
                    result = x - y;
                    if (input == result)
                    {
                        Console.WriteLine("Correct!!");
                        correct++;
                    }
                    else
                        Console.WriteLine("Wrong!");
                    z--;
                    temp--;
                }
                var average = (decimal)correct / numProb * 100;
                Console.WriteLine($"You got {correct} ouut of {numProb} correct and your grade is % {average}");
            }
        }
        public static void Multiply(int numProb)
        {
            Console.WriteLine("You are testing Multiplying and you have {0} problesm", numProb);
            Console.WriteLine("To begin your test, Press <Enter> :");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                int z = numProb;
                int input, result;
                int correct = 0;
                int temp = numProb;
                Random p = new Random();
                while (temp != 0)
                {
                    int x = p.Next(0, 100);
                    int y = p.Next(0, 100);
                    Console.Write($"{z}: {x} * {y} = ");
                    input = int.Parse(Console.ReadLine());
                    result = x * y;
                    if (input == result)
                    {
                        Console.WriteLine("Correct!!");
                        correct++;
                    }
                    else
                        Console.WriteLine("Wrong!");
                    z--;
                    temp--;
                }
                var average = (decimal)correct / numProb * 100;
                Console.WriteLine($"You got {correct} ouut of {numProb} correct and your grade is % {average}");
            }
        }
        public static void Divide(int numProb)
        {
            Console.WriteLine("You are testing Division and you have {0} problesm", numProb);
            Console.WriteLine("Please enter answer in the houndreth position.");
            Console.WriteLine("To begin your test, Press <Enter> :");
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                int z = numProb;
                decimal input, result,TempResult;
                int correct = 0;
                int temp = numProb;
                Random p = new Random();
                while (temp != 0)
                {
                    int x = p.Next(0, 100);
                    int y = p.Next(0, 100);
                    Console.Write($"{z}: {x} / {y} = ");
                    input = Decimal.Parse(Console.ReadLine());
                    TempResult = (decimal)x/y;
                    result = Math.Round(TempResult, 2);
                    if (input == result)
                    {
                        Console.WriteLine("Correct!!");
                        correct++;
                    }
                    else
                        Console.WriteLine("Wrong!");
                    z--;
                    temp--;
                }
                var average = (decimal)correct / numProb * 100;
                Console.WriteLine($"You got {correct} ouut of {numProb} correct and your grade is % {average}");
            }
        }
    }
}
