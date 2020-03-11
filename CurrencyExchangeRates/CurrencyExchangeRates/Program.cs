using System;

namespace CurrencyExchangeRates
{
    class Program
    {
        private static int currencyType;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("What would you like to convert dollar into? (input number)");
                Console.WriteLine(" 1:Euro \n 2:British Pound \n 3:Indian Ruppe \n 4:Australian Dollar" +
                            " \n 5:Canadian Dollar" +
                            "\n 6:Singapore Dollar \n 7:Malasian Ringgit");
                int currencyType = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much would you like to convert to Euro in Dollars?: ");
                double dollar = Convert.ToDouble(Console.ReadLine());

                switch (currencyType)
                {
                    case 1:
                        ToEuro Euro = new ToEuro(); // converts Dollar to EURO
                        Euro.ConvTo(dollar);
                        break;
                    case 2:
                        BritishPound BPound = new BritishPound(); // converts Dollar to British Pound
                        BPound.ConvTo(dollar);
                        break;
                    case 3:
                        IndianRupee IRupee = new IndianRupee(); // converts Dollar to Rupees
                        IRupee.ConvTo(dollar);
                        break;
                    case 4:
                        AustralianDollar AuDollar = new AustralianDollar(); // converts Dollar to AustralianDollar
                        AuDollar.ConvTo(dollar);
                        break;
                    case 5:
                        CanadianDollar CanDollar = new CanadianDollar(); /// to Canadian Dollar
                        CanDollar.ConvTo(dollar);
                        break;
                    case 6:
                        SingaporeDollar SingDollar = new SingaporeDollar(); /// to Canadian Dollar
                        SingDollar.ConvTo(dollar);
                        break;
                    case 7:
                        MalaysianRinggit MalDollar = new MalaysianRinggit(); // to Ringgit
                        MalDollar.ConvTo(dollar);
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Please enter a 1,2,3,4,5,6, or 7");
                        currencyType = 0;
                        break;
                }
            } while (currencyType == 0);
  
        }
    }
}
