namespace System
{
    public static class ServiceProviderExtensions
    {
        public static T GetService<T>(this IServiceProvider self)
        {
            object service = self.GetService(typeof(T));
            return service == null ? default(T) : (T)service;
        }
    }
}
