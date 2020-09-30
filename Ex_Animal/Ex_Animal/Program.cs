using System;
using System.Collections.Generic;

namespace Ex_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Mammal", "Garfield", 10);
            Dog dog = new Dog("Mammal", "Snoopy", 5);
            Duck duck = new Duck("Mammal", "DuckDuckGo", 1);
            
            List<ISound> animalSounds = new List<ISound> {cat, dog, duck};
            
            Console.WriteLine("");
            Console.WriteLine("Animals: ");
            Console.WriteLine("");
            Console.WriteLine("DUCK");
            Console.WriteLine($"-> Name: {duck.Name}");
            Console.WriteLine($"-> Age: {duck.Age}");
            Console.WriteLine($"-> Type: {duck.Type}");
            Console.WriteLine("");

            foreach (ISound sound in animalSounds)
            {
                Console.WriteLine(sound.Sound());
            }
        }
    }
}