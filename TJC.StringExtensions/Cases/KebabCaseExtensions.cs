namespace TJC.StringExtensions.Cases;

/// <summary>
/// Kebab case extensions for strings.
/// <para></para>
/// Example of kebab case: "kebab-case-extensions"
/// </summary>
public static class KebabCaseExtensions
{
    /// <summary>
    /// Convert any case format to kebab case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>kebab-case</returns>
    public static string ToKebabCase(this string input) =>
        string.Join("-", input.CodeCaseToWords()).ToLower();
}
