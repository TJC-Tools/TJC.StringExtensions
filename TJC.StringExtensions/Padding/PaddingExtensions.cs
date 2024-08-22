namespace TJC.StringExtensions.Padding;

public static class PaddingExtension
{
    public static string PadBoth(this string source, int length)
    {
        var spaces = length - source.Length;
        var padLeft = spaces / 2 + source.Length;
        return source.PadLeft(padLeft).PadRight(length);
    }
}