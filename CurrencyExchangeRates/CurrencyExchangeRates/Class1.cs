using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchangeRates
{       
        interface ConvFromUSD
        {  
            void ConvTo(double dollar);
        }
        class ToEuro : ConvFromUSD
        {
            public void ConvTo(double dollar)
            {
                dollar = dollar * 1.103474;
                Console.WriteLine(dollar);
            }
        }
        class BritishPound : ConvFromUSD
        {
            public void ConvTo(double dollar)
            {
            dollar = dollar * 1.300392;
            Console.WriteLine(dollar);
            }
        }
    class IndianRupee : ConvFromUSD
    {
        public void ConvTo(double dollar)
        {
            dollar = dollar * 0.013919;
            Console.WriteLine(dollar);
        }
    }
    class AustralianDollar : ConvFromUSD
    {
        public void ConvTo(double dollar)
        {
            dollar = dollar * 0.659826;
            Console.WriteLine(dollar);
        }
    }
    class CanadianDollar : ConvFromUSD
    {
        public void ConvTo(double dollar)
        {
            dollar = dollar * 0.659826;
            Console.WriteLine(dollar);
        }
    }
    class SingaporeDollar : ConvFromUSD
    {
        public void ConvTo(double dollar)
        {
            dollar = dollar * 0.714528;
            Console.WriteLine(dollar);
        }
    }
    class MalaysianRinggit : ConvFromUSD
    {
        public void ConvTo(double dollar)
        {
            dollar = dollar * 0.236153;
            Console.WriteLine(dollar);
        }
    }
}
