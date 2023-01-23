using System;
using System.Collections.Concurrent;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly ConcurrentDictionary<Type, Type> _bindings = new ConcurrentDictionary<Type, Type>();
        private readonly object _lock = new object();

        public void Bind(Type interfaceType, Type implementationType)
        {
            lock (_lock)
            {
                _bindings[interfaceType] = implementationType;
            }
        }

        public T Get<T>()
        {
            Type implementationType;
            lock (_lock)
            {
                _bindings.TryGetValue(typeof(T), out implementationType);
            }
            return (T)Activator.CreateInstance(implementationType);
        }
    }
}