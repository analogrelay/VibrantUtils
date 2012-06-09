using System.Collections.Generic;
namespace System.Linq
{
    /// <summary>
    /// Implementation of IGrouping using a Dictionary
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the grouping</typeparam>
    /// <typeparam name="TElement">The type of the elements in the grouping</typeparam>
    public class Grouping<TKey, TElement> : IGrouping<TKey, TElement>
    {
        /// <summary>
        /// Gets the key of this grouping
        /// </summary>
        public TKey Key { get; private set; }

        /// <summary>
        /// Gets the items in this grouping
        /// </summary>
        public IEnumerable<TElement> Items { get; private set; }

        /// <summary>
        /// Constructs a new grouping with the specified key and items
        /// </summary>
        /// <param name="key">The key for this grouping</param>
        /// <param name="items">The items in this grouping</param>
        public Grouping(TKey key, IEnumerable<TElement> items)
        {
            Key = key;
            Items = items;
        }

        /// <summary>
        /// Returns an <see cref="IEnumerator&lt;TElement&gt;"/> which can enumerate over the items in this group
        /// </summary>
        /// <returns></returns>
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
