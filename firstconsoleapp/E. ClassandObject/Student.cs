using System;
using System.Data;
using System.Dynamic;

class Student
{
    public Student()
    {}
    public Student(string n, byte rn)   //default constructor( a method without return type, name should match with class)
    {
        name=n;
        rollNumber=rn;

    }
    string name;  //bydefault private hunxa
    byte rollNumber;
    public byte RollNumber   //free implement property
    {
        get
        {
            return rollNumber;
        }
        set{
            if(value<=100)
            {
                rollNumber=value;
            }
        }

    }
    public string Address{get;set;}   //auto implemented property
    DateTime dob;
    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name:(name)");
        Console.WriteLine($"Student Roll no:(rollNumber)");
        Console.WriteLine($"Student Dob:(dob)");
        Console.WriteLine($"Student Address:(Address)");
    }
}
