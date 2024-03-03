public class Laptop : Product
{
    // Fields
    private string processor;
    private string ram;

    public Laptop(string id, string name, string processor, string ram)
        : base(id, name)
    {
        this.processor = processor;
        this.ram = ram;
    }

    // Properties
    public string Processor
    {
        get { return processor; }
        set { processor = value; }
    }

    public string RAM
    {
        get { return ram; }
        set { ram = value; }
    }

    public override void Display()
    {
        Console.WriteLine($"Laptop: {Name}, Processor: {Processor}, RAM: {RAM}");
    }
}