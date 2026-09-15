using TJC.StringExtensions.Lines;

namespace TJC.StringExtensions.Tests.Lines;


public class LineExtensionsTests
{
    [Fact]
    public void SplitNewLine()
    {
        // Arrange
        var text = "12345\n67890";

        // Act
        var result = text.SplitNewLine().ToList();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("12345", result[0]);
        Assert.Equal("67890", result[1]);
    }

    [Fact]
    public void SplitLines()
    {
        // Arrange
        var text = "1234 5678 90AB TEST WORD BA09 8765 4321 TEST";

        // Act
        var result = text.SplitLines(16);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal("1234 5678 90AB", result[0]);
        Assert.Equal("TEST WORD BA09", result[1]);
        Assert.Equal("8765 4321 TEST", result[2]);
    }

    [Fact]
    public void SplitLinesWithoutSpaces()
    {
        // Arrange
        var text = "1234567890TEST1001WORD0987654321TEST";

        // Act
        var result = text.SplitLines(16);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal("1234567890TEST10", result[0]);
        Assert.Equal("01WORD0987654321", result[1]);
        Assert.Equal("TEST", result[2]);
    }

    [Fact]
    public void SplitLines_NullText_ReturnsEmptyList()
    {
        var result = ((string?)null).SplitLines();

        Assert.Equal(0, result.Count);
    }

    [Fact]
    public void SplitLines_EmbeddedNewLine_CreatesSeparateLines()
    {
        var result = "first\nsecond".SplitLines(20);

        Assert.Contains("first", result);
        Assert.True(result.Any(line => line.Trim() == "second"));
    }

    [Fact]
    public void RemoveMultipleBlankLines()
    {
        // Arrange
        var text = new List<string> { "1", "2", "", "", "5", "6", "", "" };

        // Act
        var result = text.RemoveMultipleBlankLines();

        // Assert
        Assert.Equal(6, result.Count);
        Assert.Equal("1", result[0]);
        Assert.Equal("2", result[1]);
        Assert.Equal("", result[2]);
        Assert.Equal("5", result[3]);
        Assert.Equal("6", result[4]);
        Assert.Equal("", result[5]);
    }

    [Fact]
    public void RemoveMultipleBlankLines_StringInput_RemovesConsecutiveBlankLines()
    {
        var result = "first\n\n\nsecond".RemoveMultipleBlankLines();

        Assert.Equal("first\n\nsecond", result);
    }
}
