
namespace System.Collections.Generic
{
    public static class DictionaryExtensions
    {
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
