using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCard.Model
{
   public class Play
    {
        private static Card cardOnTable;
        public void StartPlay()
        {
            Console.WriteLine("Hello Lets Play card Dude");
            int noOfPlayer = 2;
            Player[] Players = new Player[noOfPlayer];
            PlayerPlayedCard[] playerPlayedCards = new PlayerPlayedCard[noOfPlayer];
            string PlayerName = "";
            for (int i = 0; i < noOfPlayer; i++)
            {
                while (PlayerName.Trim() == string.Empty)
                {
                    Console.WriteLine($"Player Name : {i + 1}");
                    PlayerName = Console.ReadLine();
                }
                Players[i] = new Player(PlayerName);
                playerPlayedCards[i] = new PlayerPlayedCard(PlayerName);
                PlayerName = string.Empty;

            }
            Deck deck = new Deck();
            deck.Shuffle();

            deck.CardIndex = (noOfPlayer * 7) - 1;
            CardOnTable = deck.NextCard;
            Console.WriteLine($"Card on the table - { CardOnTable} ");
            InitializeCardsInHand(Players, deck);
            for (int iPlayerIndx = 0; iPlayerIndx < noOfPlayer; iPlayerIndx++)
            {
                Console.WriteLine($"{Players[iPlayerIndx].Name} have Cards in Hand");
                DisplayCardsInHand(Players[iPlayerIndx]);

                string sDecision = string.Empty;
                while (sDecision.ToLower() != "t")
                {
                    Console.WriteLine("Press T to take Card");
                    sDecision = Console.ReadLine();
                }
                if (sDecision.ToLower().CompareTo("t") == 0)
                {
                    playerPlayedCards[iPlayerIndx].cards.Add(CardOnTable);
                    CardToDiscard(Players[iPlayerIndx]);
                }

            }
        }

        public static void InitializeCardsInHand(Player[] players, Deck cards)
        {
            int j = 0;
            foreach (Player player in players)
            {
                for (int i = 0; i < 7; i++)
                {
                    player.cards.Add(cards.card[j]);
                    j++;
                }
            }
        }
        public static void DisplayCardsInHand(Player p)
        {
            foreach (Card card in p.cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
        public static Card CardOnTable
        {
            get
            {
                return cardOnTable;
            }
            set
            {
                cardOnTable = value;
            }
        }

        public static void CardToDiscard(Player player)
        {
            int iCount = 1;
            foreach (Card card in player.cards)
            {
                Console.WriteLine("{0}. {1}", iCount, card.ToString());
                iCount++;
            }
            Console.WriteLine($"Select card to discard(1-{player.cards.Count})");
            string sCardToDiscard = Console.ReadLine();
            bool bValidCard = false;
            int iCardToDiscard = 0;
            while (bValidCard == false)
            {
                try
                {
                    iCardToDiscard = Convert.ToInt32(sCardToDiscard, 10);
                    if (iCardToDiscard < 1 || iCardToDiscard > 8)
                        Console.WriteLine("Please select valid card");
                    else
                        bValidCard = true;
                }
                catch
                {
                }
            }
            CardOnTable = player.cards[iCardToDiscard - 1];
            Console.WriteLine("Card drawn {0}", CardOnTable);
            player.cards.Remove(iCardToDiscard - 1);
        }
    }
}
