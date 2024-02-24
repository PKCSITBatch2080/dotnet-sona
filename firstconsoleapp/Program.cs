using System;
class Name
{
    public static void greeter()
    {
        Console.WriteLine("Your name:");
        string fullname = Console.ReadLine();
        string cfullname = fullname.ToUpper();
        Console.WriteLine($"Hello, {cfullname} Ji!");

        Console.WriteLine("Your DOB (YYYY/MM/DD):");
        string dobString = Console.ReadLine();
        DateTime dob = DateTime.Parse(dobString);
        string dobFriendly = dob.ToString("MMMM dd, yyyy");
        Console.WriteLine($"Your date of birth is: {dobFriendly}");
    }
    public static void Main(string[] args)
    {
        greeter();
    }
}




