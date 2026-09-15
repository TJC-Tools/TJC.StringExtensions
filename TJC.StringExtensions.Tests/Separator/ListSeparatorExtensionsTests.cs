using TJC.StringExtensions.Separator;

namespace TJC.StringExtensions.Tests.Separator;

public class ListSeparatorExtensionsTests
{
    private readonly List<string> _samples = ["one", "two", "three"];

    [Fact]
    public void JoinCommaTest()
    {
        // Act
        var result = _samples.JoinComma();

        // Assert
        Assert.Equal("one, two, three", result);
    }

    [Fact]
    public void JoinCommaOrTest()
    {
        // Act
        var result = _samples.JoinCommaOr(orWithComma: false);

        // Assert
        Assert.Equal("one, two or three", result);
    }

    [Fact]
    public void JoinCommaOrWithCommaTest()
    {
        // Act
        var result = _samples.JoinCommaOr(orWithComma: true);

        // Assert
        Assert.Equal("one, two, or three", result);
    }

    [Fact]
    public void JoinCommaAndTest()
    {
        // Act
        var result = _samples.JoinCommaAnd(andWithComma: false);

        // Assert
        Assert.Equal("one, two and three", result);
    }

    [Fact]
    public void JoinCommaAndWithCommaTest()
    {
        // Act
        var result = _samples.JoinCommaAnd(andWithComma: true);

        // Assert
        Assert.Equal("one, two, and three", result);
    }

    [Fact]
    public void JoinCommaAmpersandTest()
    {
        // Act
        var result = _samples.JoinCommaAmpersand(andWithComma: false);

        // Assert
        Assert.Equal("one, two & three", result);
    }

    [Fact]
    public void JoinCommaAmpersandWithCommaTest()
    {
        // Act
        var result = _samples.JoinCommaAmpersand(andWithComma: true);

        // Assert
        Assert.Equal("one, two, & three", result);
    }

    [Fact]
    public void JoinFinalSeparatorTest()
    {
        // Act
        var result = _samples.JoinFinalSeparator(".", "|");

        // Assert
        Assert.Equal("one.two|three", result);
    }

    [Fact]
    public void JoinFinalSeparator_SingleItem_ReturnsItemWithoutFinalSeparator()
    {
        var result = new List<string> { "one" }.JoinFinalSeparator(", ", " and ");

        Assert.Equal("one", result);
    }

    [Fact]
    public void JoinBulletTest()
    {
        // Act
        var result = _samples.JoinBullet();

        // Assert
        Assert.Equal("\u2022one\n\u2022two\n\u2022three", result);
    }

    [Fact]
    public void JoinNewLineTest()
    {
        // Act
        var result = _samples.JoinNewLine();

        // Assert
        Assert.Equal("one\ntwo\nthree", result);
    }

    [Fact]
    public void JoinNewLineWithSpacesTest()
    {
        // Act
        var result = _samples.JoinNewLineWithSpaces();

        // Assert
        Assert.Equal("    one\n    two\n    three", result);
    }
}
