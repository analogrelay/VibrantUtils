using System.Collections.Generic;
namespace System.Linq
{
    public class Grouping<TKey, TElement> : IGrouping<TKey, TElement>
    {
        public TKey Key { get; private set; }
        public IEnumerable<TElement> Items { get; private set; }

        public Grouping(TKey key, IEnumerable<TElement> items)
        {
            Key = key;
            Items = items;
        }

        public Collections.Generic.IEnumerator<TElement> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
