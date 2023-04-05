namespace CompositeStructuralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product phone = new Product("Phone", 1000);
            Product pc = new Product("Pc", 2000);
            Product tv = new Product("Tv", 1500);

            Package package1 = new Package("Electronics");
            package1.Products.Add(phone);
            package1.Products.Add(pc);
            package1.Products.Add(tv);

            Product book = new Product("book", 10);

            Basket basket = new Basket("My Basket");

            basket.PriceableList.Add(package1);
            basket.PriceableList.Add(book);

            decimal totalPrice = basket.TotalPrice();

            Console.WriteLine($"Total Price: {totalPrice}");
        }
    }
}