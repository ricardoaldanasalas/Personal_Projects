using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Number_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the number to convert: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Please the BASE to convert from '2', '8', or '10'");// 2 is binary #, 10 is decimal #, 8 is octal number
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Number is: {number}, and the  Base is {number2}");

                int result = 0;
                if (number2 == 2)
                {
                    result = Util.bin2dec(number);
                    Console.WriteLine($"decimal converstion is {result}");
                    result = Util.bin2oct(number);
                    Console.WriteLine($"octal converstion is {result}");
                }
                else if (number2 == 8)
                {
                    result = Util.oct2bin(number);
                    Console.WriteLine($"Binary conversion is {result}");
                    result = Util.oct2dec(number);
                    Console.WriteLine($"Decimal conversion is {result}");
                }

                else if (number2 == 10)
                {
                    Console.Write("Decimal conversiont is ");
                    Util.dec2bin(number);
                    Console.Write("Decimal to Oct is ");
                    Util.dec2oct(number);
                   

                }

            }
        }
    }

}