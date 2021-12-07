using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Visa : Debitcard, ICreditcard, IMaxCredit
    {
        public Creditcard Creditcard { get; set; }
        // How much money you can spend that you dont have.
        public int MaxOverdraft { get; set; }
        public int MaxCredit { get; set; }
        public Visa(string name) : base(name)
        {
            Creditcard = new Creditcard(name);
            PossiblePrefixes = new int[1] { 4 };
            SetAccountAndCardNr();
            Creditcard.CardNr = CardNr;
            Creditcard.AccountNr = AccountNr;
            MaxCredit = 20000;
        }
    }
}
