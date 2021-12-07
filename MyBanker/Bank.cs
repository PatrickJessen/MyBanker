using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Bank
    {
        public string Name { get; set; }

        public Card card { get; private set; }

        public Bank(string name)
        {
            Name = name;
        }

        public void MakeCard(Card c)
        {
            card = c;
        }
    }
}
