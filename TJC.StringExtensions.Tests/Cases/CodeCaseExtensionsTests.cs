using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;


public class CodeCaseExtensionsTests
{
    [Fact]
    public void SplitCodeCase_NullInput_ReturnsEmptyString()
    {
        string? input = null;

        var result = input!.SplitCodeCase();

        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void CodeCaseToWords_WhitespaceInput_ReturnsEmptyArray()
    {
        var result = " \t ".CodeCaseToWords();

        Assert.Equal(Array.Empty<string>(), result);
    }

    [Fact]
    public void SplitCodeCase_PascalCaseInput_ReturnsSeparatedWords()
    {
        var result = "SplitCodeCase".SplitCodeCase("-");

        Assert.Equal("Split-Code-Case", result);
    }
}