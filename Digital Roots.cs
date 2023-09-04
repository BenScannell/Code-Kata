//Kata: Sum of Digits / Digital Root
//Task: Create a function to find the digital root of an entered number (Add the sum of the digits until only one digit remains).
public class Number
{
    public static long DigitalRoot(long n)
    {
        while (n.ToString().Length > 1)
        {
            string strvalue = n.ToString();
            int[] digitarray = new int[strvalue.Length];
            for (int i = 0; i < strvalue.Length; i++)
            {
                digitarray[i] = int.Parse(strvalue[i].ToString());
            }
            n = digitarray.Sum();
        }
        return n;
    }
    public static void Main()
    {
        Console.WriteLine(DigitalRoot(167346));
    }
}