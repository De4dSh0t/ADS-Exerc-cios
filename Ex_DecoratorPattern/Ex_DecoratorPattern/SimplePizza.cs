namespace Ex_DecoratorPattern
{
    public class SimplePizza : IFood
    {
        public string Description { get; set; }
        public double Price { get; set; }

        public SimplePizza()
        {
            Description = "Simple Pizza";
            Price = 1;
        }

        public override string ToString()
        {
            return $"Description: {Description}. \n" +
                   $"Price: {Price}";
        }
    }
}