using System;
using System.Collections.Generic;
using System.Text;

namespace History_Test
{
    class Util
    {
        public static void Test(int amount)
        {
            string[] Q = new string[13];
            Q[0] = "Who was the first president of the United States? \n    1.John Adam\n   2.Thomas Jefferson\n    3.George Washington\n   4Barack Obama";
            Q[1] = "Who was the first black president of the United States? \n    1.Barack Obama\n   2.George Washington\n    3.John Adams\n   4.Thosmas Jeffeson";
            Q[2] = "Who was the president during the Civil War? \n    1.Theodore Roosevelt\n   2.Abraham Lincoln\n    3.George Washington\n   4.Barack Obama";
            Q[3] = "Who was the president that purchased Louisiana? \n    1.John Adam\n   2.Abraham Lincoln\n    3.George Washington\n   4.Thomas Jefferson";
            Q[4] = "Who was the president that said 'Tear down this wall!'? \n    1.Harry Truman\n   2.Thomas Jefferson\n    3.George Washington\n   4.Ronald Reagan";
            Q[5] = "Who was the president that was a famous general? \n    1.Ronald Reagan\n   2.Thomas Jefferson\n    3.Dwight Eisenhower\n   4.Barack Obama";
            Q[6] = "Who was called 'the Father of the Constitution'? \n    1.James Madison\n   2.Thomas Jefferson\n    3.George Washington\n   4.Barack Obama";
            Q[7] = "Which president was NOT from the South? \n    1.John Adam\n   2.Thomas Jefferson\n    3.George Washington\n   4.Barack Obama";
            Q[8] = "Which president wrote the Declaration of Independence? \n    1.Thomas Jefferson\n   2.Harry Truman\n    3.George Washington\n   4.Barack Obama";
            Q[9] = "Who was NOT a president from the following list? \n    1.Alexander Hamilton\n   2.Millard Filmore\n    3.George Washington\n   4. James Moroe";
            Q[10] = "Who was a president from the following list? \n    1.Benjamin Harrison\n   2.Aaron Burr\n    3.Benjamin Frank\n   4.John Tyler";
            Q[11] = "Who said: Ask not what your country can do for you, but what you can do for your country? \n    1.John Adam\n   2.Thomas Jefferson\n    3.John Kennedy\n   4.Barack Obama";
            Q[12] = "Which president invaded Canada? \n    1.John Adam\n   2.James Madison\n    3.George Washington\n   4.Barack Obama";



            Console.WriteLine("To begin your test, Press <Enter> : ");
            while(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                int temp = amount;
                Random R = new Random();
                int random = R.Next(0, Q.Length);
                int correct = 0;
                while (temp != 0)
                {

                    Console.WriteLine(Q[random] + " :");
                    Console.WriteLine("Enter your answer(1,2,3,4): ");
                    int A = int.Parse(Console.ReadLine());
                    if (random == 0 && A == 3) { Console.WriteLine("Correct! Good job"); correct++; }else{ Console.WriteLine("Incorrect"); }
                    if (random == 1 && A == 1) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 2 && A == 2) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 3 && A == 4) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 4 && A == 4) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 5 && A == 3) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 6 && A == 1) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 7 && A == 4) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 8 && A == 1) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 9 && A == 1) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 10 && A == 4) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 11 && A == 3) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    if (random == 12 && A == 2) { Console.WriteLine("Correct! Good job"); correct++; } else { Console.WriteLine("Incorrect"); }
                    temp--;
                }
                    var average = (decimal)correct / amount * 100;
                    Console.WriteLine($"You answered {correct} out of {amount} and your grade is % {average}");

            }
        }
    }
}
