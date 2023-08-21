//Kata: Vowel Count
//Task: Create a function to count how many vowels are in a given input
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return Regex.Replace(str, "[bcdfghjklmnpqrstvwxyz ]", "").Length;
    }
    public static void Main()
    {
        int output = GetVowelCount("pear tree");
        Console.WriteLine(output);
    }
}
