using System;

namespace Math_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Math Games");
         
            Util.Initialize();
            int probType = Util.x;
            int numProb = Util.y;
            if (probType == 1)
                Util.Add(numProb);
            else if (probType == 2)
                Util.Subtract(numProb);
            else if (probType == 3)
                Util.Multiply(numProb);
            else if (probType == 4)
                Util.Divide(numProb);
            else
                Console.WriteLine("Sorry you made an invalid choice.");            
        }
    }
}
