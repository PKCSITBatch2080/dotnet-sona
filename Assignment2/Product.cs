public abstract class Product : IGradeable
{
    // Fields
    private string id;

    // Read-only
    private readonly string name;

    public Product(string id, string name)
    {
        this.id = id;
        this.name = name;
    }

    // Properties
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
    }

    public abstract void Display(); // Abstract method

    public double GetGrade()
    {
        // Implement grading logic for products here
        return 4.5; // Example grade
    }
}