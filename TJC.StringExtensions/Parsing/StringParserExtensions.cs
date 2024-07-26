using System.Text.RegularExpressions;

namespace TJC.StringExtensions.Parsing;

public static partial class StringParserExtensions
{
    /// <summary>
    /// Keep Alpha Only
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string KeepAlpha(this string str) => AlphaRegex().Replace(str, string.Empty);
    [GeneratedRegex("[^a-zA-Z]")] public static partial Regex AlphaRegex();

    /// <summary>
    /// Keep Numeric Only
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string KeepNumeric(this string str) => NumericRegex().Replace(str, string.Empty);
    [GeneratedRegex("[^0-9]")] public static partial Regex NumericRegex();

    /// <summary>
    /// Keep Numeric & Period
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string KeepNumericAndPeriod(this string str) => NumericAndPeriodRegex().Replace(str, string.Empty);
    [GeneratedRegex("[^0-9.]")] public static partial Regex NumericAndPeriodRegex();

    /// <summary>
    /// Keep Alpha & Numeric
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string KeepAlphaNumeric(this string str) => AlphaNumericRegex().Replace(str, string.Empty);
    [GeneratedRegex("[^a-zA-Z0-9]")] public static partial Regex AlphaNumericRegex();

    /// <summary>
    /// Keep Alpha, Numeric & Space
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string KeepAlphaNumericAndSpace(this string str) => AlphaNumericAndSpaceRegex().Replace(str, string.Empty);
    [GeneratedRegex("[^a-zA-Z0-9 ]")] public static partial Regex AlphaNumericAndSpaceRegex();

    /// <summary>
    /// Keep Alpha, Numeric, Space & Period
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string KeepAlphaNumericSpaceAndPeriod(this string str) => AlphaNumericSpaceAndPeriodRegex().Replace(str, string.Empty);
    [GeneratedRegex("[^a-zA-Z0-9. ]")] public static partial Regex AlphaNumericSpaceAndPeriodRegex();

    /// <summary>
    /// Keep Only Alpha, Numeric, Spaces, & Excluded Symbols
    /// </summary>
    /// <param name="str"></param>
    /// <param name="exceptions"></param>
    /// <returns></returns>
    public static string RemoveSymbols(this string str, char[]? exceptions = null)
    {
        var rgx = new Regex($"[^a-zA-Z0-9{new string(exceptions)} ]");
        str = rgx.Replace(str, "");
        return str;
    }
}