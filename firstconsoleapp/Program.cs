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
        DateTime today = DateTime.Today;

TimeSpan age = today - dob;
int totalDays = Convert.ToInt32(age.TotalDays);
int totalHours = Convert.ToInt32(age.TotalHours);
int totalMinutes = Convert.ToInt32(age.TotalMinutes);

int years = totalDays / 365;
int months = (totalDays % 365) / 30;
int weeks = (totalDays % 365 % 30) / 7;
int days = totalDays % 365 % 30 % 7;

Console.WriteLine($"Hello, {cfullname} Ji");
Console.WriteLine($"Your DOB is {dob.ToString("dddd, dd MMMM yyyy")}.");

Console.WriteLine($"You are {years} years {months} months {weeks} weeks and {days} days old. \n");
    }
    public static void Main(string[] args)
    {
        greeter();
    }
}

