public class ECommerceSystem
{
    private List<Product> products;

    public ECommerceSystem()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public Product GetProduct(string id)
    {
        return products.Find(p => p.Id == id);
    }
    public void Display()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Grade: {product.GetGrade()}");
        }
    }
}
