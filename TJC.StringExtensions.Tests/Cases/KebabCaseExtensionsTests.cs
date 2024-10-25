using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

[TestClass]
public class KebabCaseExtensionsTests
{
    [TestMethod]
    public void ToKebabCaseTest()
    {
        // Arrange
        var input = "Kebab Case Extensions";
        var expected = "kebab-case-extensions";

        // Act
        var result = input.ToKebabCase();

        // Assert
        Assert.AreEqual(expected, result);
    }
}