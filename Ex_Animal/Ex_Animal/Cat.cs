namespace Ex_Animal
{
    public class Cat : Animal, ISound
    {
        public Cat(string type, string name, int age) : base(type, name, age) {}
        
        public string Sound()
        {
            return "Meow!";
        }
    }
}