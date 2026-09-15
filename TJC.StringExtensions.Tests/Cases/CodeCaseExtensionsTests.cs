using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

[TestClass]
public class CodeCaseExtensionsTests
{
    [TestMethod]
    public void SplitCodeCase_NullInput_ReturnsEmptyString()
    {
        string? input = null;

        var result = input!.SplitCodeCase();

        Assert.AreEqual(string.Empty, result);
    }

    [TestMethod]
    public void CodeCaseToWords_WhitespaceInput_ReturnsEmptyArray()
    {
        var result = " \t ".CodeCaseToWords();

        CollectionAssert.AreEqual(Array.Empty<string>(), result);
    }

    [TestMethod]
    public void SplitCodeCase_PascalCaseInput_ReturnsSeparatedWords()
    {
        var result = "SplitCodeCase".SplitCodeCase("-");

        Assert.AreEqual("Split-Code-Case", result);
    }
}
