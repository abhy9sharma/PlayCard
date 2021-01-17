using PlayCard.Enum;
using System.Collections.Generic;
using System.Text;

namespace PlayCard.Model
{
    public class Card
	{
		public Suit suit = 0;
		public Rank rank = 0;
		public Card()
		{
		}
		public Card(Rank rank, Suit suit)
		{
			this.rank = rank;
            this.suit = suit;
		}
		public override string ToString()
		{
			return "The " + rank + " of " + suit;
		}
		
	}
}
