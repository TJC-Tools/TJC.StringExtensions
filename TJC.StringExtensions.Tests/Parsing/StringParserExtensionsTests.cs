using TJC.StringExtensions.Parsing;

namespace TJC.StringExtensions.Tests.Parsing;

[TestClass]
public class StringParserExtensionsTests
{
    [TestMethod]
    public void StringParser_KeepAlpha()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlpha();

        // Assert
        Assert.AreEqual("abcde", result);
    }

    [TestMethod]
    public void StringParser_KeepNumeric()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepNumeric();

        // Assert
        Assert.AreEqual("12345", result);
    }

    [TestMethod]
    public void StringParser_KeepNumericAndPeriod()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepNumericAndPeriod();

        // Assert
        Assert.AreEqual("123.45", result);
    }

    [TestMethod]
    public void StringParser_KeepAlphaNumeric()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlphaNumeric();

        // Assert
        Assert.AreEqual("a1b2c3d4e5", result);
    }

    [TestMethod]
    public void StringParser_KeepAlphaNumericAndSpace()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlphaNumericAndSpace();

        // Assert
        Assert.AreEqual("a1b2c3d4 e5", result);
    }

    [TestMethod]
    public void StringParser_KeepAlphaNumericSpaceAndPeriod()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.KeepAlphaNumericSpaceAndPeriod();

        // Assert
        Assert.AreEqual("a1b2c3.d4 e5", result);
    }

    [TestMethod]
    public void StringParser_RemoveSymbols()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.RemoveSymbols();

        // Assert
        Assert.AreEqual("a1b2c3d4 e5", result);
    }

    [TestMethod]
    public void StringParser_RemoveSymbols_WithExceptions()
    {
        // Arrange
        var input = "a1!b2@c3#.d4$ e5%";

        // Act
        var result = input.RemoveSymbols(['!', '.']);

        // Assert
        Assert.AreEqual("a1!b2c3.d4 e5", result);
    }
}
