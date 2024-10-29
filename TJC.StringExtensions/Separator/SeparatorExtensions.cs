namespace TJC.StringExtensions.Separator;

/// <summary>
/// Separator extensions for strings.
/// </summary>
public static class SeparatorExtensions
{
    #region Join Comma & Final Separator

    /// <summary>
    /// Join strings with a comma separator.
    /// <para>Example: abc, def, ghi</para>
    /// </summary>
    /// <param name="strings"></param>
    /// <returns></returns>
    public static string JoinComma(this IEnumerable<string> strings) =>
        strings.JoinFinalSeparator(", ", ", ");

    /// <summary>
    /// Join strings with a comma separator and final separator containing or.
    /// <para>Example: abc, def or ghi</para>
    /// </summary>
    /// <param name="strings"></param>
    /// <param name="orWithComma"></param>
    /// <returns></returns>
    public static string JoinCommaOr(this IEnumerable<string> strings, bool orWithComma = false) =>
        strings.JoinFinalSeparator(", ", $"{(orWithComma ? "," : string.Empty)} or ");

    /// <summary>
    /// Join strings with a comma separator and final separator containing and.
    /// <para>Example: abc, def and ghi</para>
    /// </summary>
    /// <param name="strings"></param>
    /// <param name="andWithComma"></param>
    /// <returns></returns>
    public static string JoinCommaAnd(
        this IEnumerable<string> strings,
        bool andWithComma = false
    ) => strings.JoinFinalSeparator(", ", $"{(andWithComma ? "," : string.Empty)} and ");

    /// <summary>
    /// Join string with a comma separator and final separator containing ampersand.
    /// <para>Example: abc, def &amp; ghi</para>
    /// </summary>
    /// <param name="strings"></param>
    /// <param name="andWithComma"></param>
    /// <returns></returns>
    public static string JoinCommaAmpersand(
        this IEnumerable<string> strings,
        bool andWithComma = false
    ) => strings.JoinFinalSeparator(", ", $"{(andWithComma ? "," : string.Empty)} & ");

    /// <summary>
    /// Join strings with a comma separator and selectable final separator.
    /// <para>Example: abc, def {separator} ghi</para>
    /// </summary>
    /// <param name="strings"></param>
    /// <param name="separator"></param>
    /// <param name="finalSeparator"></param>
    /// <returns></returns>
    public static string JoinFinalSeparator(
        this IEnumerable<string> strings,
        string separator,
        string finalSeparator
    )
    {
        var list = strings.ToList();
        return string.Join(separator, list.Take(list.Count - 1))
            + (list.Count <= 1 ? string.Empty : finalSeparator)
            + list.LastOrDefault();
    }

    #endregion

    #region Join List (New Line)

    /// <summary>
    /// Join strings in a bullet point list.
    /// </summary>
    /// <param name="strings"></param>
    /// <returns></returns>
    public static string JoinBullet(this IEnumerable<string> strings) =>
        strings.JoinNewLine("\u2022");

    /// <summary>
    /// Join strings with a new line for each string.
    /// </summary>
    /// <param name="strings"></param>
    /// <param name="prefix"></param>
    /// <returns></returns>
    public static string JoinNewLine(this IEnumerable<string> strings, string? prefix = null) =>
        $"{prefix}{string.Join($"\n{prefix}", strings)}";

    /// <summary>
    /// Join strings with a new line for each string and spaces before each string.
    /// </summary>
    /// <param name="strings"></param>
    /// <param name="spaces"></param>
    /// <returns></returns>
    public static string JoinNewLineWithSpaces(this IEnumerable<string> strings, int spaces = 4) =>
        $"{new string(' ', spaces)}{string.Join($"\n{new string(' ', spaces)}", strings)}";

    #endregion

    #region Join Dictionary

    /// <summary>
    /// Join dictionary keys and values with a separator and key-value separator.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="separator"></param>
    /// <param name="keyValueSeparator"></param>
    /// <returns></returns>
    public static string JoinBoth<T1, T2>(
        this IDictionary<T1, T2> dictionary,
        string separator = ", ",
        string keyValueSeparator = ": "
    )
        where T1 : notnull
        where T2 : notnull =>
        string.Join(separator, dictionary.Select(x => $"{x.Key}{keyValueSeparator}{x.Value}"));

    /// <summary>
    /// Join dictionary keys and values with a separator and key-value separator in reverse order.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="separator"></param>
    /// <param name="valueKeySeparator"></param>
    /// <returns></returns>
    public static string JoinBothReverse<T1, T2>(
        this IDictionary<T1, T2> dictionary,
        string separator = ", ",
        string valueKeySeparator = ": "
    )
        where T1 : notnull
        where T2 : notnull =>
        string.Join(separator, dictionary.Select(x => $"{x.Value}{valueKeySeparator}{x.Key}"));

    /// <summary>
    /// Join dictionary keys with a separator.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string JoinKey<T1, T2>(
        this IDictionary<T1, T2> dictionary,
        string separator = ", "
    )
        where T1 : notnull
        where T2 : notnull => string.Join(separator, dictionary.Select(x => x.Key).ToList());

    /// <summary>
    /// Join dictionary values with a separator.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="dictionary"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static string JoinValue<T1, T2>(
        this IDictionary<T1, T2> dictionary,
        string separator = ", "
    )
        where T1 : notnull
        where T2 : notnull => string.Join(separator, dictionary.Select(x => x.Value).ToList());

    #endregion
}
