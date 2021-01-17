using System;

namespace PlayCard.Interface
{
    interface ICollectionAddRemove
    {
		public void Add(Object newobject);

		public void Remove(int CollectionIndex);
    }
}
