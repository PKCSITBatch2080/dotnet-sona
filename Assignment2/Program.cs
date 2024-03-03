
public class Program
{
    public static void Main(string[] args)
    {
        ECommerceSystem ecommerceSystem = new ECommerceSystem();

        Laptop laptop = new Laptop("123456", "Laptop", "Intel Core i7", "16GB");
        ecommerceSystem.AddProduct(laptop);
        ecommerceSystem.Display();
        Console.WriteLine("The quality is good.");
        Console.WriteLine(ecommerceSystem.GetProduct("123456").GetGrade()); // Output: 4.5
    }
}