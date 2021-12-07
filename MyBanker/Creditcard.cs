using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Creditcard : Card, IWithdrawLimit, IExpire
    {
        public int MaxMonthlyWithdrawal { get; set; }
        public int MaxDailyWithdrawal { get; set; }
        public DateTime ExpireDate { get; set; }

        public Creditcard(string name) : base(name)
        {
            ExpireDate = new DateTime(4, 11, DateTime.Now.Day);
        }

        public override string ToString()
        {
            return $"Name: {Name} \n Card Number: {CardNr} \n Account Number: {AccountNr} \n Expire: {ExpireDate.Year}/{ExpireDate.Month}";
        }
    }
}
