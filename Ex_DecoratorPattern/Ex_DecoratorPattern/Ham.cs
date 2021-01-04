namespace Ex_DecoratorPattern
{
    public class Ham : Decorator
    {
        public Ham(IFood food) : base(food)
        {
            food.Description += ", with Ham";
            food.Price += 0.5;
        }
    }
}