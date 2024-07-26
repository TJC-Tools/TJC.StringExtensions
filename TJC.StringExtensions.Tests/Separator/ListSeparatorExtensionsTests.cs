using TJC.StringExtensions.Separator;

namespace TJC.StringExtensions.Tests.Separator;

[TestClass]
public class ListSeparatorExtensionsTests
{
    private readonly List<string> _samples = ["one", "two", "three"];

    [TestMethod]
    public void JoinCommaTest()
    {
        // Act
        var result = _samples.JoinComma();

        // Assert
        Assert.AreEqual("one, two, three", result);
    }

    [TestMethod]
    public void JoinCommaOrTest()
    {
        // Act
        var result = _samples.JoinCommaOr(orWithComma: false);

        // Assert
        Assert.AreEqual("one, two or three", result);
    }

    [TestMethod]
    public void JoinCommaOrWithCommaTest()
    {
        // Act
        var result = _samples.JoinCommaOr(orWithComma: true);

        // Assert
        Assert.AreEqual("one, two, or three", result);
    }

    [TestMethod]
    public void JoinCommaAndTest()
    {
        // Act
        var result = _samples.JoinCommaAnd(andWithComma: false);

        // Assert
        Assert.AreEqual("one, two and three", result);
    }

    [TestMethod]
    public void JoinCommaAndWithCommaTest()
    {
        // Act
        var result = _samples.JoinCommaAnd(andWithComma: true);

        // Assert
        Assert.AreEqual("one, two, and three", result);
    }

    [TestMethod]
    public void JoinCommaAmpersandTest()
    {
        // Act
        var result = _samples.JoinCommaAmpersand(andWithComma: false);

        // Assert
        Assert.AreEqual("one, two & three", result);
    }

    [TestMethod]
    public void JoinCommaAmpersandWithCommaTest()
    {
        // Act
        var result = _samples.JoinCommaAmpersand(andWithComma: true);

        // Assert
        Assert.AreEqual("one, two, & three", result);
    }

    [TestMethod]
    public void JoinFinalSeparatorTest()
    {
        // Act
        var result = _samples.JoinFinalSeparator(".", "|");

        // Assert
        Assert.AreEqual("one.two|three", result);
    }

    [TestMethod]
    public void JoinBulletTest()
    {
        // Act
        var result = _samples.JoinBullet();

        // Assert
        Assert.AreEqual("\u2022one\n\u2022two\n\u2022three", result);
    }

    [TestMethod]
    public void JoinNewLineTest()
    {
        // Act
        var result = _samples.JoinNewLine();

        // Assert
        Assert.AreEqual("one\ntwo\nthree", result);
    }

    [TestMethod]
    public void JoinNewLineWithSpacesTest()
    {
        // Act
        var result = _samples.JoinNewLineWithSpaces();

        // Assert
        Assert.AreEqual("    one\n    two\n    three", result);
    }
}