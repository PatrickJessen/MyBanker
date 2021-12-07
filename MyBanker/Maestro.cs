using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : Debitcard, IExpire, IInternational
    {
        public DateTime ExpireDate { get; set; }
        public Maestro(string name) : base(name)
        {
            // Initialize prefixes and overrides it from Debitcard
            PossiblePrefixes = new int[9] { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };

            // Maestro card is the only card not to have 16 digit card number, so i set it in here only for maestro card.
            CardNr = GetRandomPrefix() + GenerateRandomNr(19, GetPrefixLength());
            AccountNr = GenerateRandomNr(14, 0);
            //set expiry date to 5 years and 8 months from when the card gets created.
            ExpireDate = new DateTime(5, 8, DateTime.Now.Day);
        }

        public override string ToString()
        {
            return $"Name: {Name} \n Card Number: {CardNr} \n Account Number: {AccountNr} \n Expire: {ExpireDate.Year}/{ExpireDate.Month}";
        }
    }
}
