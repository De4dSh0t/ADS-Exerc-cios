namespace Ex_Animal
{
    public class Dog : Animal, ISound
    {
        public Dog(string type, string name, int age) : base(type, name, age) {}

        public string Sound()
        {
            return "Woof!";
        }
    }
}