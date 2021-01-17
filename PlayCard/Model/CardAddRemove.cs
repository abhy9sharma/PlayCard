using PlayCard.Interface;
using System.Collections;

namespace PlayCard.Model
{
    public class CardAddRemove: CollectionBase, ICollectionAddRemove
	{
		public Card this[int CardIndex]
		{
			get
			{
				return (Card)List[CardIndex];
			}
			set
			{
				List[CardIndex] = value;
			}
		}

		public void Remove(int cardIndex)
		{
			List.RemoveAt(cardIndex);
		}

        public void Add(object newobject)
        {
			List.Add(newobject);
		}

       
	}
}
