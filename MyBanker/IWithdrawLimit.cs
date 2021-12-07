using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface IWithdrawLimit
    {
        // Max money you can withdrawl monthly
        public int MaxMonthlyWithdrawal { get; set; }
        // Max money you can withdrawl daily
        public int MaxDailyWithdrawal { get; set; }
    }
}
