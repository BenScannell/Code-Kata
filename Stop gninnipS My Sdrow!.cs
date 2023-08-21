using System.Collections.Generic;
using System.Linq;
using System;
public class program
{
    //Codewars Kata: Stop gninnipS My sdroW!
    //Task: Create a function which takes a string and reverses any words which are 5 characters or longer.
    public static string SpinWords(string sentence)
    {
        string[] tokenized = sentence.Split(' ');
        int i = 0;
        while (i < tokenized.Length)
        {
            if (tokenized[i].Length > 5)
            {
                string toreplace = tokenized[i];
                char[] chars = tokenized[i].ToCharArray();
                Array.Reverse(chars);
                string charsstr = new string(chars);
                sentence = sentence.Replace(toreplace , charsstr);
            }
            i++;
        }
        return sentence;
    }
    public static void Main()
    {
        string test = SpinWords("Hey fellow warriors");
        Console.WriteLine(test);
    }
}