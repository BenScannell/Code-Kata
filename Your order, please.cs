//Kata: Your order, please
//Task: Create a function which orders a set of words in a string by the numbers contained in those words. For example "is2 Thi1s T4est 3a" would return "Thi1s is2 3a T4est"
using System.Text.RegularExpressions;
public static class Kata
{
    public static string Order(string words)
    {
        if (string.IsNullOrEmpty(words))// Error handling for a null input
        {
            return words;
        }
        string[] tokens = words.Split(' ');// words split into an array
        string[] result = new string[tokens.Length];
        for (int i = 0; i < tokens.Length; i++) // iterating on the "tokens array"
        {
            string number = Regex.Match(tokens[i], @"\d+").Value;// Extract the number contained in each token
            int numbera = Int32.Parse(number);// Convert extracted number to an integer value
            result[numbera-1] = tokens[i];
        }
        return string.Join(" ", result);
    }
    public static void Main()
    {
        Console.WriteLine(Order("is2 Thi1s T4est 3a"));
    }
}