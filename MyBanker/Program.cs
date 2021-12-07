using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBanker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bank bank = new Bank("MyBanker");

            bank.MakeCard(new Mastercard("Patrick"));
            Console.WriteLine(bank.card.ToString());

            bank.MakeCard(new Maestro("Hans"));
            Console.WriteLine(bank.card.ToString());

            bank.MakeCard(new Visa("Grethe"));
            Console.WriteLine(((ICreditcard)(bank.card)).Creditcard.ToString());
        }
    }
}