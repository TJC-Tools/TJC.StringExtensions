namespace TJC.StringExtensions.Cases;

/// <summary>
/// Train case extensions for strings.
/// <para></para>
/// Example of train case: "Train-Case-Extensions"
/// </summary>
public static class TrainCaseExtensions
{
    /// <summary>
    /// Convert any case format to train case.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Train-Case</returns>
    public static string ToTrainCase(this string input) =>
        string.Join(
            "-",
            input.CodeCaseToWords().Select(word => char.ToUpper(word[0]) + word[1..].ToLower())
        );
}
