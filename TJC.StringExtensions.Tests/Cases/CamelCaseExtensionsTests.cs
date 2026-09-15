using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

public class CamelCaseExtensionsTests
{
    [Fact]
    public void SplitCamelCase_Null_ReturnsEmpty()
    {
        // Arrange
        string? input = null;
        var expected = string.Empty;

        // Act
        var result = input.SplitCamelCase();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SplitCamelCase_FirstLetterLowercase_SplitsWithSpace()
    {
        // Arrange
        var input = "camelCaseExtensions";
        var expected = "camel Case Extensions";

        // Act
        var result = input.SplitCamelCase();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SplitCamelCase_FirstLetterUppercase_SplitsWithSpace()
    {
        // Arrange
        var input = "CamelCaseExtensions";
        var expected = "Camel Case Extensions";

        // Act
        var result = input.SplitCamelCase();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ToCamelCaseTest()
    {
        // Arrange
        var input = "Camel Case Extensions";
        var expected = "camelCaseExtensions";

        // Act
        var result = input.ToCamelCase();

        // Assert
        Assert.Equal(expected, result);
    }
}
