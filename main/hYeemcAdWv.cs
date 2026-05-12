using System;
using System.Text;
using System.Linq;
public class StringUtilities
{
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public static string ToTitleCase(string input)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
    }
    public static int CountVowels(string input)
    {
        return input.Count(c => "aeiouAEIOU".Contains(c));
    }
    public static string RemoveWhitespace(string input)
    {
        return input.Replace(" ", "").Replace("\t", "").Replace("\n", "");
    }
    public static string Truncate(string input, int maxLength)
    {
        if (input.Length <= maxLength)
            return input;
        return input.Substring(0, maxLength) + "...";
    }
    public static bool IsPalindrome(string input)
    {
        string reversed = Reverse(input);
        return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
    }
    public static string[] SplitByComma(string input)
    {
        return input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
    }
    public static string JoinWithComma(string[] inputs)
    {
        return string.Join(",", inputs);
    }
    public static string RemoveSpecialCharacters(string input)
    {
        var builder = new StringBuilder();
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                builder.Append(c);
        }
        return builder.ToString();
    }
    public static string Repeat(string input, int count)
    {
        return string.Concat(Enumerable.Repeat(input, count));
    }
}
