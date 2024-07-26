namespace TJC.StringExtensions.Separator;

public static class SeparatorExtensions
{
    #region Join Comma & Final Separator

    public static string JoinComma(this IEnumerable<string> strings) =>
        strings.JoinFinalSeparator(", ", ", ");

    public static string JoinCommaOr(this IEnumerable<string> strings, bool orWithComma = false) =>
        strings.JoinFinalSeparator(", ", $"{(orWithComma ? "," : string.Empty)} or ");

    public static string JoinCommaAnd(this IEnumerable<string> strings, bool andWithComma = false) =>
        strings.JoinFinalSeparator(", ", $"{(andWithComma ? "," : string.Empty)} and ");

    public static string JoinCommaAmpersand(this IEnumerable<string> strings, bool andWithComma = false) =>
        strings.JoinFinalSeparator(", ", $"{(andWithComma ? "," : string.Empty)} & ");

    public static string JoinFinalSeparator(this IEnumerable<string> strings, string separator, string finalSeparator)
    {
        var list = strings.ToList();
        return string.Join(separator, list.Take(list.Count - 1)) + (list.Count <= 1 ? string.Empty : finalSeparator) + list.LastOrDefault();
    }

    #endregion

    #region Join List (New Line)

    public static string JoinBullet(this IEnumerable<string> strings) =>
        strings.JoinNewLine("\u2022");

    public static string JoinNewLine(this IEnumerable<string> strings, string? prefix = null) =>
        $"{prefix}{string.Join($"\n{prefix}", strings)}";

    public static string JoinNewLineWithSpaces(this IEnumerable<string> strings, int spaces = 4) =>
        $"{new string(' ', spaces)}{string.Join($"\n{new string(' ', spaces)}", strings)}";

    #endregion

    #region Join Dictionary

    public static string JoinBoth<T1, T2>(this IDictionary<T1, T2> dictionary, string separator = ", ", string keyValueSeparator = ": ")
        where T1 : notnull
        where T2 : notnull =>
        string.Join(separator, dictionary.Select(x => $"{x.Key}{keyValueSeparator}{x.Value}"));

    public static string JoinBothReverse<T1, T2>(this IDictionary<T1, T2> dictionary, string separator = ", ", string valueKeySeparator = ": ")
        where T1 : notnull
        where T2 : notnull =>
        string.Join(separator, dictionary.Select(x => $"{x.Value}{valueKeySeparator}{x.Key}"));

    public static string JoinKey<T1, T2>(this IDictionary<T1, T2> dictionary, string separator = ", ")
        where T1 : notnull
        where T2 : notnull =>
        string.Join(separator, dictionary.Select(x => x.Key).ToList());

    public static string JoinValue<T1, T2>(this IDictionary<T1, T2> dictionary, string separator = ", ")
        where T1 : notnull
        where T2 : notnull =>
        string.Join(separator, dictionary.Select(x => x.Value).ToList());

    #endregion
}