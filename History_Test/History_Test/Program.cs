using System;

namespace History_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test bank initialized");
            Console.WriteLine("How many question would you like to answer? Enter from 1 to 14: ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Test Question created, {0} questions." ,amount);
            Console.WriteLine("--------------------------------");
            Util.Test(amount);

        }
    }
}
