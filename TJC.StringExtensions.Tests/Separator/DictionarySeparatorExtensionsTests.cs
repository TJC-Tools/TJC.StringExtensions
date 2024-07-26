using TJC.StringExtensions.Separator;

namespace TJC.StringExtensions.Tests.Separator;

[TestClass]
public class DictionarySeparatorExtensionsTests
{
    private readonly Dictionary<int, string> _samples = new() { { 1, "one" }, { 2, "two" }, { 3, "three" } };

    [TestMethod]
    public void JoinBothTest()
    {
        // Act
        var result = _samples.JoinBoth();

        // Assert
        Assert.AreEqual("1: one, 2: two, 3: three", result);
    }

    [TestMethod]
    public void JoinBothReverseTest()
    {
        // Act
        var result = _samples.JoinBothReverse();

        // Assert
        Assert.AreEqual("one: 1, two: 2, three: 3", result);
    }

    [TestMethod]
    public void JoinKeyTest()
    {
        // Act
        var result = _samples.JoinKey();

        // Assert
        Assert.AreEqual("1, 2, 3", result);
    }

    [TestMethod]
    public void JoinValueTest()
    {
        // Act
        var result = _samples.JoinValue();

        // Assert
        Assert.AreEqual("one, two, three", result);
    }
}