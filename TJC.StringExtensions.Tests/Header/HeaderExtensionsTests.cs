using TJC.StringExtensions.Header;

namespace TJC.StringExtensions.Tests.Header;

[TestClass]
public class HeaderExtensionsTests
{
    [TestMethod]
    public void GetHeader()
    {
        // Arrange
        var headerLines = new List<string> { "Title", "This is a description", "and this is another line" };

        // Act
        var result = headerLines.GenerateHeader().ToList();

        // Assert
        Assert.AreEqual(5, result.Count);
        Assert.AreEqual("####################################", result[0]);
        Assert.AreEqual("###            Title             ###", result[1]);
        Assert.AreEqual("###    This is a description     ###", result[2]);
        Assert.AreEqual("###   and this is another line   ###", result[3]);
        Assert.AreEqual("####################################", result[4]);
    }
}