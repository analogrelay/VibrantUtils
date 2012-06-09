namespace System.Collections.Generic
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds all the items in the specified list to the collection
        /// </summary>
        /// <typeparam name="T">The type of the items to add</typeparam>
        /// <param name="self">The collection to add the items to</param>
        /// <param name="items">The items to add</param>
        public static void AddRange<T>(this ICollection<T> self, IEnumerable<T> items)
        {
            items.Each(self.Add);
        }
    }
}
