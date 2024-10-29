using TJC.StringExtensions.Lines;

namespace TJC.StringExtensions.Tests.Lines;

[TestClass]
public class LineExtensionsTests
{
    [TestMethod]
    public void SplitNewLine()
    {
        // Arrange
        var text = "12345\n67890";

        // Act
        var result = text.SplitNewLine().ToList();

        // Assert
        Assert.AreEqual(2, result.Count);
        Assert.AreEqual("12345", result[0]);
        Assert.AreEqual("67890", result[1]);
    }

    [TestMethod]
    public void SplitLines()
    {
        // Arrange
        var text = "1234 5678 90AB TEST WORD BA09 8765 4321 TEST";

        // Act
        var result = text.SplitLines(16);

        // Assert
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual("1234 5678 90AB", result[0]);
        Assert.AreEqual("TEST WORD BA09", result[1]);
        Assert.AreEqual("8765 4321 TEST", result[2]);
    }

    [TestMethod]
    public void SplitLinesWithoutSpaces()
    {
        // Arrange
        var text = "1234567890ABCD1001DCBA0987654321TEST";

        // Act
        var result = text.SplitLines(16);

        // Assert
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual("1234567890ABCDEF", result[0]);
        Assert.AreEqual("FEDCBA0987654321", result[1]);
        Assert.AreEqual("TEST", result[2]);
    }

    [TestMethod]
    public void RemoveMultipleBlankLines()
    {
        // Arrange
        var text = new List<string> { "1", "2", "", "", "5", "6", "", "" };

        // Act
        var result = text.RemoveMultipleBlankLines();

        // Assert
        Assert.AreEqual(6, result.Count);
        Assert.AreEqual("1", result[0]);
        Assert.AreEqual("2", result[1]);
        Assert.AreEqual("", result[2]);
        Assert.AreEqual("5", result[3]);
        Assert.AreEqual("6", result[4]);
        Assert.AreEqual("", result[5]);
    }
}
