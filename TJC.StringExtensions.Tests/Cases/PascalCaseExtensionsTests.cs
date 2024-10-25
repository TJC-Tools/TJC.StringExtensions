using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

[TestClass]
public class PascalCaseExtensionsTests
{
    [TestMethod]
    public void ToPascalCaseTest()
    {
        // Arrange
        var input = "Pascal Case Extensions";
        var expected = "PascalCaseExtensions";

        // Act
        var result = input.ToPascalCase();

        // Assert
        Assert.AreEqual(expected, result);
    }
}