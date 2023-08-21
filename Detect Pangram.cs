//Kata: Detect Pangram
//Task: Write a function  to check if a sentence is a "pangram" meaning that it contains every letter of the alphabet
using System;
public static class Kata
{
    public static bool IsPangram(string str)
    {
        int alpha = 0;
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (str.Contains(c, System.StringComparison.CurrentCultureIgnoreCase) == true)
            {
                alpha++;
            }
        }
        return alpha == 26;
    }
    public static void Main()
    {
        IsPangram("The quick brown fox jumped over the lazy dog.");
    }
}