using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

public class TrainCaseExtensionsTests
{
    [Fact]
    public void ToTrainCaseTest()
    {
        // Arrange
        var input = "Train Case Extensions";
        var expected = "Train-Case-Extensions";

        // Act
        var result = input.ToTrainCase();

        // Assert
        Assert.Equal(expected, result);
    }
}
