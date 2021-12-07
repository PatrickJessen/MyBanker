using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface IMaxCredit
    {
        // Max credit there can be on a card
        public int MaxCredit { get; set; }
    }
}
