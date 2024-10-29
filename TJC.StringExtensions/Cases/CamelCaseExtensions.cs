namespace TJC.StringExtensions.Cases;

/// <summary>
/// Camel case extensions for strings.
/// <para></para>
/// Example of camel case: "camelCaseExtensions"
/// </summary>
public static class CamelCaseExtensions
{
    /// <summary>
    /// Split camel case with a separator (typically a space).
    /// </summary>
    /// <param name="input"></param>
    /// <param name="separator"></param>
    /// <returns>"camelCaseExtensions" becomes "camel Case Extensions"</returns>
    public static string SplitCamelCase(this string? input, string separator = " ")
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
        return string.Concat(
            input.Select((x, i) => i > 0 && char.IsUpper(x) ? $"{separator}{x}" : x.ToString())
        );
    }

    /// <summary>
    /// Convert any case format to camel case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>camelCase</returns>
    public static string ToCamelCase(this string input)
    {
        var words = input.CodeCaseToWords();
        var result = new StringBuilder(words[0].ToLower());
        for (int i = 1; i < words.Length; i++)
            result.Append(char.ToUpper(words[i][0]) + words[i][1..].ToLower());
        return result.ToString();
    }
}
