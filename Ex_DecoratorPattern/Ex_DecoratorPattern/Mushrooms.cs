namespace Ex_DecoratorPattern
{
    public class Mushrooms : Decorator
    {
        public Mushrooms(IFood food) : base(food)
        {
            food.Description += ", with mushrooms";
            food.Price += 0.3;
        }
    }
}