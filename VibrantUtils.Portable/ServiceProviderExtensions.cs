namespace System
{
    public static class ServiceProviderExtensions
    {
        /// <summary>
        /// Gets the service object of the specified type
        /// </summary>
        /// <typeparam name="T">The type of service object to get</typeparam>
        /// <param name="self">The service provider containing the service object</param>
        /// <returns>The service object, or the default value for <typeparamref name="T"/> if no such service exists.</returns>
        public static T GetService<T>(this IServiceProvider self)
        {
            object service = self.GetService(typeof(T));
            return service == null ? default(T) : (T)service;
        }
    }
}
