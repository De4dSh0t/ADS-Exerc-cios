using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPublisher sensor = new Publisher();
            ISubscribe device1 = new Subscriber();
            ISubscribe device2 = new Subscriber();
            Random random = new Random();
            
            // Add
            sensor.AddSubscriber(device1);
            sensor.AddSubscriber(device2);
            
            // Notify (without value)
            sensor.NotifySubscribers();

            // Remove
            sensor.RemoveSubscriber(device1);
            
            // Notify (with value)
            sensor.NotifySubscribers(random.Next(1, 101));
        }
    }
}