using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : Creditcard, IMaxCredit
    {
        public int MaxCredit { get; set; }
        public Mastercard(string name) : base(name)
        {
            // Initialize prefixes.
            PossiblePrefixes = new int[5] { 51, 52, 53, 54, 55 };
            SetAccountAndCardNr();
            MaxCredit = 40000;
        }
    }
}
