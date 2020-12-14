using System.Collections.Generic;

namespace ObserverPattern
{
    public class Publisher : IPublisher
    {
        private HashSet<ISubscribe> subscribers = new HashSet<ISubscribe>();
        
        public void AddSubscriber(ISubscribe subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscribe subscriber)
        {
            if (!subscribers.Contains(subscriber)) return;
            
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Notify();
            }
        }

        public void NotifySubscribers(int val)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Notify(val);
            }
        }
    }
}