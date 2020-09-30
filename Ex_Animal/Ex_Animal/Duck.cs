namespace Ex_Animal
{
    public class Duck : Animal, ISound
    {
        public Duck(string type, string name, int age) : base(type, name, age) {}

        public string Sound()
        {
            return "Quack!";
        }
    }
}