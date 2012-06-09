
namespace System.Collections.Generic
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Gets the requested value from the dictionary, or if it not present, creates it using the specified factory
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary</typeparam>
        /// <typeparam name="TElement">The type of the values in the dictionary</typeparam>
        /// <param name="self">The dictionary to get the item from</param>
        /// <param name="key">The key of the item to retrieve, or store if the item is not present</param>
        /// <param name="factory">The factory function which creates the object if it is not present in the dictionary</param>
        /// <returns>The value, either retrieved from the dictionary, or constructed by the factory (and then stored)</returns>
        public static TElement GetOrCreate<TKey, TElement>(this IDictionary<TKey, TElement> self, TKey key, Func<TElement> factory)
        {
            TElement val;
            if (!self.TryGetValue(key, out val))
            {
                self[key] = val = factory();
            }
            return val;
        }

        /// <summary>
        /// Gets the requested value from the dictionary, or if it not present, returns the default value for this type
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary</typeparam>
        /// <typeparam name="TElement">The type of the values in the dictionary</typeparam>
        /// <param name="self">The dictionary to get the item from</param>
        /// <param name="key">The key of the item to retrieve</param>
        /// <returns>The value, if present, or the default value for that type if the value is not present</returns>
        public static TVal GetOrDefault<TKey, TVal>(this IDictionary<TKey, TVal> self, TKey key)
        {
            TVal result;
            if (!self.TryGetValue(key, out result))
            {
                return default(TVal);
            }
            return result;
        }
    }
}
