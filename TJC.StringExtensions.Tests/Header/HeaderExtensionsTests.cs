using TJC.StringExtensions.Header;

namespace TJC.StringExtensions.Tests.Header;


public class HeaderExtensionsTests
{
    [Fact]
    public void GetHeader()
    {
        // Arrange
        var headerLines = new List<string>
        {
            "Title",
            "This is a description",
            "and this is another line",
        };

        // Act
        var result = headerLines.GenerateHeader().ToList();

        // Assert
        Assert.Equal(5, result.Count);
        Assert.Equal("####################################", result[0]);
        Assert.Equal("###            Title             ###", result[1]);
        Assert.Equal("###    This is a description     ###", result[2]);
        Assert.Equal("###   and this is another line   ###", result[3]);
        Assert.Equal("####################################", result[4]);
    }
}
