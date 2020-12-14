namespace ObserverPattern
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscribe subscriber);
        void RemoveSubscriber(ISubscribe subscriber);
        void NotifySubscribers();
        void NotifySubscribers(int val);
    }
}