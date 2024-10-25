namespace TJC.StringExtensions.Lines;

/// <summary>
/// Extensions for lines of text.
/// </summary>
public static class LineExtensions
{
    private const int MaxLineWidth = 60;

    /// <summary>
    /// Split string into lines by new line character.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static IEnumerable<string> SplitNewLine(this string inputString) =>
        inputString.ReplaceLineEndings().Split(Environment.NewLine);

    /// <summary>
    /// Split string into lines when they exceed the width.
    /// <para>Try to split near a separator character, e.g. a space ' '</para>
    /// </summary>
    /// <param name="text"></param>
    /// <param name="width"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static List<string> SplitLines(this string? text, int width = MaxLineWidth, char separator = ' ')
    {
        var list = new List<string>();
        if (text == null)
            return list;

        var array = text.Split(separator);
        foreach (var word in array)
            foreach (var subword in word.SplitChunks(width))
                list.AddWord(subword, width, separator);

        return list;
    }

    /// <summary>
    /// Split string into chunks of specified size.
    /// </summary>
    /// <param name="str"></param>
    /// <param name="chunkSize"></param>
    /// <returns></returns>
    public static IEnumerable<string> SplitChunks(this string str, int chunkSize)
    {
        for (var i = 0; i < str.Length; i += chunkSize)
            yield return str.Substring(i, Math.Min(chunkSize, str.Length - i));
    }

    /// <summary>
    /// Add Word to Line if less than Width,
    /// Create New Line if more than Width,
    /// Create New Line if there is a New Line Character
    /// </summary>
    /// <param name="lines"></param>
    /// <param name="word"></param>
    /// <param name="width"></param>
    /// <param name="separator"></param>
    private static void AddWord(this List<string> lines, string word, int width, char separator = ' ')
    {
        word = word.ReplaceLineEndings();
        if (!word.Contains(Environment.NewLine))
        {
            if (lines.Count == 0 || word.Length + lines[^1].Length > width)
                lines.Add(word);
            else
                lines[^1] += string.Concat(separator, word);
            return;
        }

        var array = word.Split(Environment.NewLine);
        lines.AddWord(array[0], width, separator);
        foreach (string item in array.Skip(1))
        {
            lines.Add(string.Empty);
            lines.AddWord(item, width, separator);
        }
    }

    /// <summary>
    /// Remove multiple blank lines in a row from text.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string RemoveMultipleBlankLines(this string text) =>
        text.SplitNewLine().RemoveMultipleBlankLines().JoinNewLine();

    /// <summary>
    /// Remove multiple blank lines in a row from lines.
    /// </summary>
    /// <param name="lines"></param>
    /// <returns></returns>
    public static List<string> RemoveMultipleBlankLines(this IEnumerable<string> lines)
    {
        var lastLineWasBlank = false;
        var list = new List<string>();
        foreach (string item in lines.Where((string line) => !string.IsNullOrWhiteSpace(line) || !lastLineWasBlank))
        {
            list.Add(item);
            lastLineWasBlank = string.IsNullOrWhiteSpace(item);
        }

        return list;
    }
}