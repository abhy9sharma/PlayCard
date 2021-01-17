using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCard.Model
{
	public class Player
	{
		public string Name;
		public CardAddRemove cards;
		public Player(string playerName)
		{
			Name = playerName;
			cards = new CardAddRemove();
		}
	}

	public class PlayerPlayedCard
	{
		public string Name;
		public CardAddRemove cards;
		public PlayerPlayedCard(string playerName)
		{
			Name = playerName;
			cards = new CardAddRemove();
		}
	}

}
