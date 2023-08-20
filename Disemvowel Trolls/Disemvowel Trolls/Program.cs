using System;
public static class Main
{
    //Kata: Disemvowel Trolls
    //Task: Create a function to remove any vowels from a string passed to it
    public static string Disemvowel(string str)
    {
        string[] vovels = {"a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
        for (int i = 0; i < vovels.Length; i++) {
            str = str.Replace(vovels[i], "");
        }
        return str;
    }
}