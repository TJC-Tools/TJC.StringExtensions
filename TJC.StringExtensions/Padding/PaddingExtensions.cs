namespace TJC.StringExtensions.Padding;

/// <summary>
/// Padding extensions for strings.
/// </summary>
public static class PaddingExtension
{
    /// <summary>
    /// Pad a string with spaces on both sides to make it the specified length.
    /// </summary>
    /// <param name="source"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string PadBoth(this string source, int length)
    {
        var spaces = length - source.Length;
        var padLeft = spaces / 2 + source.Length;
        return source.PadLeft(padLeft).PadRight(length);
    }
}
