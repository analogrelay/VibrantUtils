using System.Collections.ObjectModel;
using System.Linq;

namespace System.Collections.Generic
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Interleave<T>(this IEnumerable<T> self, Func<T> generator)
        {
            bool first = true;
            foreach (var item in self)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    yield return generator();
                }
                yield return item;
            }
        }
        
        public static IEnumerable<T> NonNull<T>(this IEnumerable<T> self) where T : class
        {
            return self.Where(item => item != null);
        }

        public static void Each<T>(this IEnumerable<T> self, Action<T> act)
        {
            foreach (T item in self)
            {
                act(item);
            }
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> self, T item)
        {
            foreach (var existing in self)
            {
                yield return existing;
            }
            yield return item;
        }

        public static IEnumerable<IGrouping<TKey, TElement>> CollectBy<TKey, TElement>(this IEnumerable<TElement> self, Func<TElement, IEnumerable<TKey>> keysSelector)
        {
            var dict = new Dictionary<TKey, IList<TElement>>();
            foreach (var value in self)
            {
                var keys = keysSelector(value);
                foreach (var key in keys)
                {
                    dict.GetOrCreate(key, () => new List<TElement>())
                        .Add(value);
                }
            }
            return dict.Select(pair => (IGrouping<TKey, TElement>)new Grouping<TKey, TElement>(pair.Key, new ReadOnlyCollection<TElement>(pair.Value)));
        }
    }
}
