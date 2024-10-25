using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

[TestClass]
public class SnakeCaseExtensionsTests
{
    [TestMethod]
    public void ToSnakeCaseTest()
    {
        // Arrange
        var input = "Snake Case Extensions";
        var expected = "snake_case_extensions";

        // Act
        var result = input.ToSnakeCase();

        // Assert
        Assert.AreEqual(expected, result);
    }
}