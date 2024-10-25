using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

[TestClass]
public class CamelCaseExtensionsTests
{
    [TestMethod]
    public void SplitCamelCase_Null_ReturnsEmpty()
    {
        // Arrange
        string? input = null;
        var expected = string.Empty;

        // Act
        var result = input.SplitCamelCase();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SplitCamelCase_FirstLetterLowercase_SplitsWithSpace()
    {
        // Arrange
        var input = "camelCaseExtensions";
        var expected = "camel Case Extensions";

        // Act
        var result = input.SplitCamelCase();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SplitCamelCase_FirstLetterUppercase_SplitsWithSpace()
    {
        // Arrange
        var input = "CamelCaseExtensions";
        var expected = "Camel Case Extensions";

        // Act
        var result = input.SplitCamelCase();

        // Assert
        Assert.AreEqual(expected, result);
    }
}