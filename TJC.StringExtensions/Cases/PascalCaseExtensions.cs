namespace TJC.StringExtensions.Cases;

/// <summary>
/// Pascal case extensions for strings.
/// <para></para>
/// Example of pascal case: "PascalCaseExtensions"
/// </summary>
public static class PascalCaseExtensions
{
    /// <summary>
    /// Convert any case format to pascal case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>PascalCase</returns>
    public static string ToPascalCase(this string input)
    {
        var words = input.CodeCaseToWords();
        var result = new StringBuilder();
        foreach (var word in words)
            result.Append(char.ToUpper(word[0]) + word[1..].ToLower());
        return result.ToString();
    }
}