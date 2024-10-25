namespace TJC.StringExtensions.Cases;

/// <summary>
/// Snake case extensions for strings.
/// <para></para>
/// Example of snake case: "snake-case-extensions"
/// </summary>
public static class SnakeCaseExtensions
{
    /// <summary>
    /// Convert any case format to snake case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>snake_case</returns>
    public static string ToSnakeCase(this string input) =>
        string.Join("_", input.CodeCaseToWords()).ToLower();
}