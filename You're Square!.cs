//Kata: You're Square!
//Task: Create a simple function to determine whether an integer input is a square number
using System;
public class Kata
{
    public static bool IsSquare(int n)
    {
        double a = Convert.ToDouble(n);
        a = Math.Sqrt(a);
        return ((a % 1) ==0);
    }
    public static void Main()
    {
        bool output = IsSquare(0);
        Console.WriteLine(output);
    }
}