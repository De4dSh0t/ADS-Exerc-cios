using System;

namespace Ex_DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFood pizza = new SimplePizza();
            Decorator decorator = new Ham(pizza);
            Console.WriteLine(pizza);
            decorator = new Mushrooms(pizza);
            Console.WriteLine(pizza);
            decorator = new Tomato(pizza);
            Console.WriteLine(pizza);
        }
    }
}