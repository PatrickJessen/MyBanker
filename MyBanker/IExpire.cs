using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface IExpire
    {
        // Date the card expires.
        public DateTime ExpireDate { get; protected set; }
    }
}
