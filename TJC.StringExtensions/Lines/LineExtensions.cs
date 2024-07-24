namespace TJC.StringExtensions.Lines;

public static class LinesExtension
{
    private const int MaxLineWidth = 60;

    public static IEnumerable<string> SplitNewLine(this string inputString) =>
        inputString.ReplaceLineEndings().Split(Environment.NewLine);

    public static List<string> SplitLines(this string? text, int width = MaxLineWidth, char separator = ' ')
    {
        var list = new List<string> { string.Empty };
        if (text == null)
            return list;

        var array = text.Split(separator);
        foreach (string word in array)
            list.AddWord(word, width, separator);

        return list;
    }

    private static void AddWord(this List<string> lines, string word, int width, char separator)
    {
        word = word.ReplaceLineEndings();
        if (!word.Contains(Environment.NewLine))
        {
            if (word.Length + lines[^1].Length > width)
                lines.Add(string.Empty);

            lines[^1] += string.Concat(word, separator);
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

    public static string RemoveMultipleBlankLines(this string text) =>
        text.SplitNewLine().RemoveMultipleBlankLines().JoinNewLine();

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