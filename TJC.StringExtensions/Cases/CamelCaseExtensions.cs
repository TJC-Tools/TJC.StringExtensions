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
    /// <para></para>
    /// Example: "camelCaseExtensions" becomes "camel Case Extensions"
    /// </summary>
    /// <param name="input"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string SplitCamelCase(this string input, string separator = " ")
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
        return string.Concat(input.Select((x, i) => i > 0 && char.IsUpper(x) ? $"{separator}{x}" : x.ToString()));
    }
}