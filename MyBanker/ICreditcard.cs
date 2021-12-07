using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface ICreditcard
    {
        // Interface of Creditcard so different cards can also inherit from other types of cards
        public Creditcard Creditcard { get; set; }
    }
}
