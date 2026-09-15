using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;


public class SnakeCaseExtensionsTests
{
    [Fact]
    public void ToSnakeCaseTest()
    {
        // Arrange
        var input = "Snake Case Extensions";
        var expected = "snake_case_extensions";

        // Act
        var result = input.ToSnakeCase();

        // Assert
        Assert.Equal(expected, result);
    }
}
