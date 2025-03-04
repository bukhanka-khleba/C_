using System;
using System.Linq;

public static class exercise2
{
    public static string[] GetWordsWithMaxLength(string message, int n)
    {
        if (string.IsNullOrEmpty(message))
            return Array.Empty<string>();
        
        return message.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                     .Where(word => word.Length <= n)
                     .ToArray();
    }

    public static string RemoveWordsEndingWith(string message, char endChar)
    {
        if (string.IsNullOrEmpty(message))
            return string.Empty;

        return string.Join(" ", 
            message.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                   .Where(word => !word.EndsWith(endChar.ToString(), StringComparison.Ordinal)));
    }

    public static string FindLongestWord(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            return string.Empty;

        var words = message.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return words.Length == 0 
            ? string.Empty 
            : words.Aggregate((max, current) => current.Length > max.Length ? current : max);
    }
}