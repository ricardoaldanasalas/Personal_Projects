using System;
using System.Linq;


namespace Roulette
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] number = new[]{ 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
                20, 21, 22, 23, 24, 25, 26, 27,28, 29, 30, 31, 32, 33, 34, 35, 36 };          
            Random Ran = new Random();
            int R = number[Ran.Next(number.Length)];
            
            // Numbers
            Console.WriteLine($"1. Numbers: The number of the bin is {R} !!");           

            // Even or Odds
            if (R % 2 == 1)
                Console.WriteLine($"2. Evens/Odds: {R} is a ODD number!");
            else if (R % 2 != 1)
                Console.WriteLine($"2. Evens/Odds: {R} is a EVEN number!");


            // Red/Blacks
            int[] Red = { 14, 23, 26, 21, 18, 19, 12, 25, 27, 1, 36, 3, 34, 5, 32, 7, 30, 9 };
            int[] Black = { 2, 35, 4, 33, 6, 31, 8, 29, 10, 13, 24, 15, 22, 17, 20, 11, 26, 28 };
            int[] Zero = { 0, 00 };
            if (Red.Contains(R))
                Console.WriteLine("3. Your Color is Red");
            else if (Black.Contains(R))
                Console.WriteLine("3. Your Color is Black");
            else
                Console.WriteLine("3. Your Color is Green!");

            //Lows/Highs
            if (R <= 18)
                Console.WriteLine("4. Your number is LOW!!");
            else
                Console.WriteLine("4. Your Number is High!!");
            //Dozens
            if (R <= 12)
                Console.WriteLine("5. You number is on the first box");
            else if (R > 12 && R <= 24)
                Console.WriteLine("5. Your number is on the second box");
            else
                Console.WriteLine("5. Your number is on the third box");

            //Columns
            int[] Col1 = { 1, 4, 7, 10, 14, 16, 19, 22, 25, 28, 31, 34 };
            int[] Col2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            if (Col1.Contains(R))
                Console.WriteLine("6. Your number is on the fist Column");
            else if (Col2.Contains(R))
                Console.WriteLine("6. Your number is on the second columns");
            else
                Console.WriteLine("6. your number is on the third columns");
            //Rows
            int[] Row1 = { 1, 2, 3 };
            int[] Row2 = { 4, 5, 6 };
            int[] Row3 = { 7, 8, 9 };
            int[] Row4 = { 10, 11, 12 };
            int[] Row5 = { 13, 14, 15 };
            int[] Row6 = { 16, 17, 18 };
            int[] Row7 = { 19, 20,21 };
            int[] Row8 = { 22, 23, 24 };
            int[] Row9 = { 25, 26, 27 };
            int[] Row10 = { 28, 29, 30 };
            int[] Row11 = { 31, 32, 33 };
            int[] Row12= { 34, 35, 36 };
            int[] Row13 = { 0,00};


            if (Row13.Contains(R))
                Console.WriteLine("7. Your number is on the first row");
            else if (Row1.Contains(R))
                Console.WriteLine("7. Your number is on the Second Row");
            else if (Row2.Contains(R))
                Console.WriteLine("7. Your number is on the Third Row");
            else if (Row3.Contains(R))
                Console.WriteLine("7. Your number is on the Fourth Row");
            else if (Row4.Contains(R))
                Console.WriteLine("7. Your number is on the Fifth Row");
            else if (Row5.Contains(R))
                Console.WriteLine("7. Your number is on the Sixth Row");
            else if (Row6.Contains(R))
                Console.WriteLine("7. Your number is on the Seventh Row");
            else if (Row7.Contains(R))
                Console.WriteLine("7. Your number is on the Eight Row");
            else if (Row8.Contains(R))
                Console.WriteLine("7. Your number is on the Nineth Row");
            else if (Row9.Contains(R))
                Console.WriteLine("7. Your number is on the Tenth Row");
            else if (Row10.Contains(R))
                Console.WriteLine("7. Your number is on the Eleventh Row");
            else if (Row11.Contains(R))
                Console.WriteLine("7. Your number is on the Twelveth Row");
            else if (Row12.Contains(R))
                Console.WriteLine("7. Your number is on the Thirteenth Row");







        }
    }
}
