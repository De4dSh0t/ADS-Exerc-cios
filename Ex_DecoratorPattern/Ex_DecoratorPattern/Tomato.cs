namespace Ex_DecoratorPattern
{
    public class Tomato : Decorator
    {
        public Tomato(IFood food) : base(food)
        {
            food.Description += ", with tomato";
            food.Price += 1.2;
        }
    }
}