namespace ObserverPattern
{
    public interface ISubscribe
    {
        void Notify();
        void Notify(int val);
    }
}