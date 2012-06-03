namespace System.Collections.Generic
{
    public static class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> self, IEnumerable<T> items)
        {
            items.Each(self.Add);
        }

        public static TElement GetOrCreate<TKey, TElement>(this IDictionary<TKey, TElement> self, TKey key, Func<TElement> creator)
        {
            TElement val;
            if (!self.TryGetValue(key, out val))
            {
                self[key] = val = creator();
            }
            return val;
        }
    }
}
