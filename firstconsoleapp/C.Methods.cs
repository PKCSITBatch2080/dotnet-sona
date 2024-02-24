using System;
class Methods
{
public void Greet()
{
    Console.WriteLine("hey, there");
}
public void Greet(string greeting)
{
    Console.WriteLine($"{greeting},there!");   //using interpolation
}
public float CalculateBMI(float weightInKg, float heightInFt)
{
    var heightInM= heightInFt*0.3048f;
    var bmi= weightInKg/(heightInM* heightInM);
    return bmi; 
}
}