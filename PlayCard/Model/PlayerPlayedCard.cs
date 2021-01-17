namespace PlayCard.Model
{
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
