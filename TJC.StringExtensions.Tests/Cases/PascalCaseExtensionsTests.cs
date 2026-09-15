using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

public class PascalCaseExtensionsTests
{
    [Fact]
    public void ToPascalCaseTest()
    {
        // Arrange
        var input = "Pascal Case Extensions";
        var expected = "PascalCaseExtensions";

        // Act
        var result = input.ToPascalCase();

        // Assert
        Assert.Equal(expected, result);
    }
}
