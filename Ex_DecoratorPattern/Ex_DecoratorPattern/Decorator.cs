namespace Ex_DecoratorPattern
{
    public abstract class Decorator
    {
        private readonly IFood food;

        protected Decorator(IFood food)
        {
            this.food = food;
        }
    }
}