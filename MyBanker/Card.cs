using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        public long CardNr { get; set; }
        public long AccountNr { get; set; }
        protected int[] PossiblePrefixes { get; set; }
        public string Name { get; set; }

        public Card(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Sets the CardNr with a random generated prefix and random generated 14 digit number minus the prefix length.
        /// Sets the AccountNr with a random generated 14 digit number.
        /// </summary>
        protected void SetAccountAndCardNr()
        {
            CardNr = GetRandomPrefix() + GenerateRandomNr(16, GetPrefixLength());
            AccountNr = GenerateRandomNr(14, 0);
        }

        /// <summary>
        /// Generates a random number with a specified length
        /// </summary>
        /// <param name="length">length of how long the number should be</param>
        /// <returns></returns>
        protected long GenerateRandomNr(int length, int minusPrefix)
        {
            Random rand = new Random();
            string randNr = "";
            for (int i = 0; i < length - minusPrefix; i++)
                randNr += rand.Next(0, 9);

            return long.Parse(randNr);
        }

        /// <summary>
        /// Gets a random prefix from PossiblePrefix array
        /// </summary>
        /// <returns></returns>
        protected int GetRandomPrefix()
        {
            Random rand = new Random();
            int randPrefix = rand.Next(0, PossiblePrefixes.Length);   
            return PossiblePrefixes[randPrefix];
        }

        /// <summary>
        /// Gets the length of our prefix
        /// </summary>
        /// <returns>length of our prefix</returns>
        protected int GetPrefixLength()
        {
            // Converts the prefix to a string then assigns it to a char array so i can get the length of how many digits there is.
            char[] temp = GetRandomPrefix().ToString().ToCharArray();
            return temp.Length;
        }
    }
}
