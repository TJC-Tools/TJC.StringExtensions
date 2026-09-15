using TJC.StringExtensions.Pluralize;

namespace TJC.StringExtensions.Tests.Pluralize;

public class PluralizeExtensionsTests
{
    [Fact]
    public void Pluralize_ObjectCollection_CountZero_ReturnsPluralized()
    {
        // Arrange
        var objects = new List<object>();

        // Act
        var result = objects.Pluralize("item");

        // Assert
        Assert.Equal("items", result);
    }

    [Fact]
    public void Pluralize_ObjectCollection_CountOne_ReturnsNonPluralized()
    {
        // Arrange
        var objects = new List<object> { new() };

        // Act
        var result = objects.Pluralize("item");

        // Assert
        Assert.Equal("item", result);
    }

    [Fact]
    public void Pluralize_ObjectCollection_CountTwo_ReturnsPluralized()
    {
        // Arrange
        var objects = new List<object>();

        // Act
        var result = "item".Pluralize(objects);

        // Assert
        Assert.Equal("items", result);
    }

    [InlineData(0, "items")]
    [InlineData(1, "item")]
    [InlineData(2, "items")]
    [Theory]
    public void Pluralize_Number_ReturnsCorrectPluralization(int number, string expected)
    {
        // Act
        var result = "item".Pluralize(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [InlineData(0, "items")]
    [InlineData(1, "item")]
    [InlineData(2, "items")]
    [Theory]
    public void Pluralize_Double_ReturnsCorrectPluralization(double number, string expected)
    {
        // Act
        var result = "item".Pluralize(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Pluralize_CustomPlural_ReturnsCustomPluralWhenRequired()
    {
        var result = "person".Pluralize(2, "people");

        Assert.Equal("people", result);
    }

    [Fact]
    public void IsOne_InvalidStringNumber_ReturnsFalse()
    {
        var result = "not a number".IsOne();

        Assert.False(result);
    }

    [Fact]
    public void IsOne_StringIsOne_ReturnsTrue()
    {
        // Arrange
        var number = "1";

        // Act
        var result = number.IsOne();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsOne_StringIsNotOne_ReturnsFalse()
    {
        // Arrange
        var number = "2";

        // Act
        var result = number.IsOne();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsOne_DoubleIsOne_ReturnsTrue()
    {
        // Arrange
        var number = 1.0;

        // Act
        var result = number.IsOne();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsOne_DoubleIsNotOne_ReturnsFalse()
    {
        // Arrange
        var number = 2.0;

        // Act
        var result = number.IsOne();

        // Assert
        Assert.False(result);
    }
}
