using System;

namespace ObserverPattern
{
    public class Subscriber : ISubscribe
    {
        public void Notify()
        {
            Console.WriteLine("Sensor was triggered.");
        }

        public void Notify(int val)
        {
            Console.WriteLine($"Sensor detected movement: {val}");
        }
    }
}