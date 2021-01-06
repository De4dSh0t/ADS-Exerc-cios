using System.Collections.Generic;

namespace ObserverPattern
{
    public class Publisher : IPublisher
    {
        private HashSet<ISubscribe> subscribers = new HashSet<ISubscribe>();
        
        public IPublisher AddSubscriber(ISubscribe subscriber)
        {
            subscribers.Add(subscriber);
            return this;
        }

        public IPublisher RemoveSubscriber(ISubscribe subscriber)
        {
            if (!subscribers.Contains(subscriber)) return this;
            
            subscribers.Remove(subscriber);
            return this;
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