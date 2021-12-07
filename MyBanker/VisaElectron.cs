using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaElectron : Debitcard, IWithdrawLimit, IInternational, IExpire
    {
        public int MaxMonthlyWithdrawal { get; set; }
        public int MaxDailyWithdrawal { get; set; }
        public DateTime ExpireDate { get; set; }

        public VisaElectron(string name) : base(name)
        {
            // Initialize prefixes and overrides it from Debitcard
            PossiblePrefixes = new int[6] { 4026, 417500, 4508, 4844, 4913, 4917 };
            SetAccountAndCardNr();
            ExpireDate = new DateTime(4, 11, DateTime.Now.Day);
        }

        public override string ToString()
        {
            return $"Name: {Name} \n Card Number: {CardNr} \n Account Number: {AccountNr} \n Expire: {ExpireDate.Year}/{ExpireDate.Month}";
        }
    }
}
