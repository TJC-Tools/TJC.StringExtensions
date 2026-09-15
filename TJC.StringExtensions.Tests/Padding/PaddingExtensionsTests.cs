using TJC.StringExtensions.Padding;

namespace TJC.StringExtensions.Tests.Padding;

public class PaddingExtensionsTests
{
    [Fact]
    public void PadBoth_Unbalanced1()
    {
        // Arrange
        var text = "abc";

        // Act
        var result = text.PadBoth(4);

        // Assert
        Assert.Equal("abc ", result);
    }

    [Fact]
    public void PadBoth_Balanced1()
    {
        // Arrange
        var text = "abc";

        // Act
        var result = text.PadBoth(5);

        // Assert
        Assert.Equal(" abc ", result);
    }

    [Fact]
    public void PadBoth_Unbalanced2()
    {
        // Arrange
        var text = "abc";

        // Act
        var result = text.PadBoth(6);

        // Assert
        Assert.Equal(" abc  ", result);
    }

    [Fact]
    public void PadBoth_Balanced2()
    {
        // Arrange
        var text = "abc";

        // Act
        var result = text.PadBoth(7);

        // Assert
        Assert.Equal("  abc  ", result);
    }

    [Fact]
    public void PadBoth_Unbalanced3()
    {
        // Arrange
        var text = "abc";

        // Act
        var result = text.PadBoth(8);

        // Assert
        Assert.Equal("  abc   ", result);
    }
}
