namespace Decorator_Pattern.IceCream
{
    public class IceCreamWithSmarties : IceCreamDecorator
    {
        public IceCreamWithSmarties(IceCream iceCream) : base(iceCream)
        {
        }

        public override int GetPrice()
        {
            return (base.GetPrice() + (base.GetPrice() * 10 / 100));
        }
    }
}
