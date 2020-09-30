namespace Ex_Animal
{
    public class Animal
    {
        public string Type { get; }
        public string Name { get; }
        public int Age { get; }

        protected Animal(string type, string name, int age)
        {
            Type = type;
            Name = name;
            Age = age;
        }

        public string Walk(float distance)
        {
            return $"I'm walking {distance}.";
        }

        public string Stay(float time)
        {
            return $"I'm going to stay still for {time}.";
        }

        public string Eat(string food)
        {
            return $"I'm eating {food}.";
        }
    }
}