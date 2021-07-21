namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            /*******************************************
             * Step1
            /******************************************/

            var largeIce = new IceCream.LargeIceCream();

            var price0 = largeIce.GetPrice();

            System.Console.WriteLine($"Large ice cream : { price0 }");


            /*******************************************
             * Step2
             * Large ice cream with smarties
            /******************************************/
            var largeIceCream = new IceCream.LargeIceCream();
            var iceCreamWithSmarties = new IceCream.IceCreamWithSmarties(largeIceCream);

            var price1 = iceCreamWithSmarties.GetPrice();

            System.Console.WriteLine($"Large ice cream with smarties : { price1 }");

            /*******************************************
             * Step3
             * Small ice cream with chocolate
            /******************************************/
            var smallIceCream = new IceCream.SmallIceCream();
            var iceCreamWithChocolate = new IceCream.IceCreamWithChocolate(smallIceCream);

            var price2 = iceCreamWithChocolate.GetPrice();

            System.Console.WriteLine($"Small ice cream with chocolate : { price2 }");

            /*******************************************
             * Step4
             * Medium ice cream with chocolate and smarties
            /******************************************/
            var mediumIceCream = new IceCream.MediumIceCream();
            var mediumIceCreamWithChocolate = new IceCream.IceCreamWithChocolate(mediumIceCream);
            var iceCreamWithSmartiesAndChocolate = new IceCream.IceCreamWithSmarties(mediumIceCreamWithChocolate);
            var price3= iceCreamWithSmartiesAndChocolate.GetPrice();

            System.Console.WriteLine($"Medium ice cream with chocolate and smarties : { price3 }");
            System.Console.ReadKey();
        }
    }
}
