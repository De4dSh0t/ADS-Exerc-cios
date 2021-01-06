namespace ObserverPattern
{
    public interface IPublisher
    {
        IPublisher AddSubscriber(ISubscribe subscriber);
        IPublisher RemoveSubscriber(ISubscribe subscriber);
        void NotifySubscribers();
        void NotifySubscribers(int val);

        public static IPublisher operator +(IPublisher p, ISubscribe s)
        {
            return p.AddSubscriber(s);
        }
        
        public static IPublisher operator -(IPublisher p, ISubscribe s)
        {
            return p.RemoveSubscriber(s);
        }
    }
}