using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Utilities
{
    /// <summary>
    /// This class implements INotifyPropertyChanged
    /// and INotifyPropertyChanging in a 
    /// serialization-safe manner.
    /// </summary>
    [Serializable()]
    public abstract class BindableBase : INotifyPropertyChanged, INotifyPropertyChanging
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        //public event PropertyChangingEventHandler PropertyChanging;
        [NonSerialized()]
        private PropertyChangedEventHandler _nonSerializableChangedHandlers;
        private PropertyChangedEventHandler _serializableChangedHandlers;

        /// <summary>
        /// Implements a serialization-safe PropertyChanged event.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design",
          "CA1062:ValidateArgumentsOfPublicMethods")]
        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (ShouldHandlerSerialize(value))
                    _serializableChangedHandlers = (PropertyChangedEventHandler)
                      System.Delegate.Combine(_serializableChangedHandlers, value);
                else
                    _nonSerializableChangedHandlers = (PropertyChangedEventHandler)
                      System.Delegate.Combine(_nonSerializableChangedHandlers, value);
            }
            remove
            {
                if (ShouldHandlerSerialize(value))
                    _serializableChangedHandlers = (PropertyChangedEventHandler)
                      System.Delegate.Remove(_serializableChangedHandlers, value);
                else
                    _nonSerializableChangedHandlers = (PropertyChangedEventHandler)
                      System.Delegate.Remove(_nonSerializableChangedHandlers, value);
            }
        }

        /// <summary>
        /// Override this method to change the default logic for determining 
        /// if the event handler should be serialized
        /// </summary>
        /// <param name="value">the event handler to review</param>
        /// <returns></returns>
        protected virtual bool ShouldHandlerSerialize(PropertyChangedEventHandler value)
        {
            return value.Method.IsPublic &&
                   value.Method.DeclaringType != null &&
                   (value.Method.DeclaringType.IsSerializable || value.Method.IsStatic);
        }


        [NonSerialized()]
        private PropertyChangingEventHandler _nonSerializableChangingHandlers;
        private PropertyChangingEventHandler _serializableChangingHandlers;

        /// <summary>
        /// Implements a serialization-safe PropertyChanging event.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design",
          "CA1062:ValidateArgumentsOfPublicMethods")]
        public event PropertyChangingEventHandler PropertyChanging
        {
            add
            {
                if (ShouldHandlerSerialize(value))
                    _serializableChangingHandlers = (PropertyChangingEventHandler)
                      System.Delegate.Combine(_serializableChangingHandlers, value);
                else
                    _nonSerializableChangingHandlers = (PropertyChangingEventHandler)
                      System.Delegate.Combine(_nonSerializableChangingHandlers, value);
            }
            remove
            {
                if (ShouldHandlerSerialize(value))
                    _serializableChangingHandlers = (PropertyChangingEventHandler)
                      System.Delegate.Remove(_serializableChangingHandlers, value);
                else
                    _nonSerializableChangingHandlers = (PropertyChangingEventHandler)
                      System.Delegate.Remove(_nonSerializableChangingHandlers, value);
            }
        }


        /// <summary>
        /// Call this method to raise the PropertyChanging event
        /// for a specific property.
        /// </summary>
        /// <param name="propertyName">Name of the property that
        /// has Changing.</param>
        /// <remarks>
        /// This method may be called by properties in the business
        /// class to indicate the change in a specific property.
        /// </remarks>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected virtual void OnPropertyChanging(string propertyName)
        {
            if (_nonSerializableChangingHandlers != null)
                _nonSerializableChangingHandlers.Invoke(this,
                  new PropertyChangingEventArgs(propertyName));
            if (_serializableChangingHandlers != null)
                _serializableChangingHandlers.Invoke(this,
                  new PropertyChangingEventArgs(propertyName));
        }

        /// <summary>
        /// Call this method to raise the PropertyChanging event
        /// for a specific property.
        /// </summary>
        /// <param name="propertyInfo">PropertyInfo of the property that
        /// has Changing.</param>
        /// <remarks>
        /// This method may be called by properties in the business
        /// class to indicate the change in a specific property.
        /// </remarks>
        //[EditorBrowsable(EditorBrowsableState.Advanced)]
        //protected virtual void OnPropertyChanging(IPropertyInfo propertyInfo)
        //{
        //    OnPropertyChanging(propertyInfo.Name);
        //}

        /// <summary>
        /// Override this method to change the default logic for determining 
        /// if the event handler should be serialized
        /// </summary>
        /// <param name="value">the event handler to review</param>
        /// <returns></returns>
        protected virtual bool ShouldHandlerSerialize(PropertyChangingEventHandler value)
        {
            return value.Method.IsPublic &&
                   value.Method.DeclaringType != null &&
                   (value.Method.DeclaringType.IsSerializable || value.Method.IsStatic);
        }
    }
}
