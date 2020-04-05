using System;
using System.Collections.Generic;
using System.Text;

namespace Base_Number_Conversion
{
    class Util
    {
       
        public static int bin2dec(int number)
        {
            int decimalValue=0;
            int base1 = 1;
            while(number > 0)
            {
                int reminder = number % 10;
                number = number / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;  
            }
            return decimalValue;
        }
        public static int bin2oct(int number)
        {
            int n1, p = 1;
            int dec = 0, i = 1,j, d;
            int ocno = 0;

            n1 = number;
            for (j = number; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                dec = dec + (d * p);
                i++;
            }
            i = 1;
            for (j = dec; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i;
                i = i * 10;
                number = number / 8;
            }
            return ocno;
        }
        public static int oct2bin(int number)
        {
            int n1, p = 1;
            int dec = 0, i = 1, j, d;
            int ocno = 0;

            n1 = number;
            for (j = number; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                dec = dec + (d * p);
                i++;
            }
            i = 1;
            for (j = dec; j > 0; j = j / 2)
            {
                ocno = ocno + (j % 2) * i;
                i = i * 10;
                number = number / 2;
            }
            return ocno;
        }
        public static int oct2dec(int number)
        {
            int decimalValue = 0;
            int base1 = 1;
            while (number > 0)
            {
                int reminder = number % 10;
                number = number / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 8;
            }
            return decimalValue;
        }
        public static void dec2bin(int number)
        {
            int[] decimalValue = new int[20];
            int i = 0;
            int y = 0;
            while (number > 0)
            {
                int reminder = number % 2;
                number = number / 2;               
                decimalValue[i] = reminder;
                i++;
                Console.Write(decimalValue[y]);
                y++;
            }
            Console.WriteLine();
        }
        public static void dec2oct(int number)
        {
            int[] decimalValue = new int[10];
            int i = 0;
            while (number > 0)
            {
                int reminder = number % 8;
                number = number / 8;
                decimalValue[i] = reminder;
                i++;
            }
            int[] temp = decimalValue;
            Array.Reverse(temp);
            foreach (int x in temp)
                 Console.Write(x);
            Console.WriteLine();
        }
    }
}
