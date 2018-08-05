using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        int wordLength = word.Length;
        word = word.ToLower();
        int i = 0;

        if (wordLength == 0) { return false; }

        foreach (char c in word)
        {
            if (c != word[(wordLength - 1) - i]) { return false; }
            i++;

            if (i == wordLength / 2) { break; }
        }

        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
        Console.ReadKey();
    }
}