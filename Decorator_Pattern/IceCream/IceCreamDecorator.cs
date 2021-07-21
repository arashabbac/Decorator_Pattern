namespace Decorator_Pattern.IceCream
{
    public class IceCreamDecorator : IceCream
    {
        private readonly IceCream _iceCream;

        public IceCreamDecorator(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public override int GetPrice()
        {
            return (_iceCream.GetPrice());
        }
    }
}
