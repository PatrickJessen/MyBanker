using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Debitcard : Card
    {
        public Debitcard(string name) : base(name)
        {
            // Initialize default prefixes here
            PossiblePrefixes = new int[1] { 2400 };
        }

        /// <summary>
        /// Withdraw money
        /// </summary>
        /// <param name="amount">amount of money</param>
        public void Withdraw(int amount)
        {
            // money -= amount;
        }

        public override string ToString()
        {
            return $"Name: {Name} \n Card Number: {CardNr} \n Account Number: {AccountNr}";
        }
    }
}
