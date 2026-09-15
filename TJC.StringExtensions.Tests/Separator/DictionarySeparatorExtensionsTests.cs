using TJC.StringExtensions.Separator;

namespace TJC.StringExtensions.Tests.Separator;


public class DictionarySeparatorExtensionsTests
{
    private readonly Dictionary<int, string> _samples = new()
    {
        { 1, "one" },
        { 2, "two" },
        { 3, "three" },
    };

    [Fact]
    public void JoinBothTest()
    {
        // Act
        var result = _samples.JoinBoth();

        // Assert
        Assert.Equal("1: one, 2: two, 3: three", result);
    }

    [Fact]
    public void JoinBothReverseTest()
    {
        // Act
        var result = _samples.JoinBothReverse();

        // Assert
        Assert.Equal("one: 1, two: 2, three: 3", result);
    }

    [Fact]
    public void JoinKeyTest()
    {
        // Act
        var result = _samples.JoinKey();

        // Assert
        Assert.Equal("1, 2, 3", result);
    }

    [Fact]
    public void JoinValueTest()
    {
        // Act
        var result = _samples.JoinValue();

        // Assert
        Assert.Equal("one, two, three", result);
    }
}
