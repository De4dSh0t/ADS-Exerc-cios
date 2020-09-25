using System;

namespace GenericSingleton
{
    public class Singleton<T> where T : new()
    {
        private static readonly T InstanceHolder = new T();
        
        static Singleton() {}

        private Singleton() {}

        public static T Instance => InstanceHolder;
    }
}