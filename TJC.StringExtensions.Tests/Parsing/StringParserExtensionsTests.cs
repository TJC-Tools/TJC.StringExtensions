using TJC.StringExtensions.Parsing;

namespace TJC.StringExtensions.Tests.Parsing;


public class StringParserExtensionsTests
{
    [Fact]
    public void StringParser_KeepAlpha()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlpha();

        // Assert
        Assert.Equal("abcde", result);
    }

    [Fact]
    public void StringParser_KeepNumeric()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepNumeric();

        // Assert
        Assert.Equal("12345", result);
    }

    [Fact]
    public void StringParser_KeepNumericAndPeriod()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepNumericAndPeriod();

        // Assert
        Assert.Equal("123.45", result);
    }

    [Fact]
    public void StringParser_KeepAlphaNumeric()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlphaNumeric();

        // Assert
        Assert.Equal("a1b2c3d4e5", result);
    }

    [Fact]
    public void StringParser_KeepAlphaNumericAndSpace()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlphaNumericAndSpace();

        // Assert
        Assert.Equal("a1b2c3d4 e5", result);
    }

    [Fact]
    public void StringParser_KeepAlphaNumericSpaceAndPeriod()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlphaNumericSpaceAndPeriod();

        // Assert
        Assert.Equal("a1b2c3.d4 e5", result);
    }

    [Fact]
    public void StringParser_RemoveSymbols()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.RemoveSymbols();

        // Assert
        Assert.Equal("a1b2c3d4 e5", result);
    }

    [Fact]
    public void StringParser_RemoveSymbols_WithExceptions()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.RemoveSymbols(['!', '.']);

        // Assert
        Assert.Equal("a1!b2c3.d4 e5", result);
    }
}
