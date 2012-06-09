using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
    /// <summary>
    /// Base class which provides a simple implementation of INotifyPropertyChanged
    /// </summary>
    public abstract class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Fired when a property on this object changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Sets the backing field of the specified property to the new value and fires the PropertyChanged event, if the value is different
        /// </summary>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <param name="backingField">The backing field which stores the value for this property</param>
        /// <param name="newValue">The new value for the property</param>
        /// <param name="propertyName">(OPTIONAL in C# 5.0, provided by CallerMemberName) The name of the property being set.</param>
        protected virtual void SetProperty<T>(ref T backingField, T newValue, [CallerMemberName] string propertyName = null)
        {
            Debug.Assert(propertyName != null, "The propertyName parameter of SetProperty must be specified when compiling with C# versions lower than 5.0");
            if (propertyName == null)
            {
                throw new ArgumentNullException(propertyName);
            }

            if (!Equals(backingField, newValue))
            {
                backingField = newValue;
                OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Fires the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="args">The arguments to provide to listeners of the event.</param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }
}
