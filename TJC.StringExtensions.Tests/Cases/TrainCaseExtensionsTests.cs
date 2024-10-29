using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

[TestClass]
public class TrainCaseExtensionsTests
{
    [TestMethod]
    public void ToTrainCaseTest()
    {
        // Arrange
        var input = "Train Case Extensions";
        var expected = "Train-Case-Extensions";

        // Act
        var result = input.ToTrainCase();

        // Assert
        Assert.AreEqual(expected, result);
    }
}
