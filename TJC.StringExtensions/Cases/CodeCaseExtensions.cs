namespace TJC.StringExtensions.Cases;

/// <summary>
/// Case extensions for strings.
/// </summary>
public static partial class CodeCaseExtensions
{
    private static readonly char[] _separator = [' ', '_', '-'];

    /// <summary>
    /// Splits any code case format with a separator.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string SplitCodeCase(this string input, string separator = " ")
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
        return string.Join(separator, input.CodeCaseToWords());
    }

    /// <summary>
    /// Convert any code case format to words array.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string[] CodeCaseToWords(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return [];
        // Add spaces around transitions (camelCase, PascalCase) and split by space, hyphen, or underscore        
        var spaced = CaseWordSplitter.Replace(input, " ");
        return spaced.Split(_separator, StringSplitOptions.RemoveEmptyEntries);
    }

    private static readonly Regex CaseWordSplitter = CaseWordSplitterRegex();

    [GeneratedRegex(@"(?<!^)(?=[A-Z])|[_\- ]", RegexOptions.Compiled)]
    private static partial Regex CaseWordSplitterRegex();
}