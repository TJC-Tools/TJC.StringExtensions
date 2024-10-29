using TJC.StringExtensions.Cases;

namespace TJC.StringExtensions.Tests.Cases;

[TestClass]
public class KebabCaseExtensionsTests
{
    [TestMethod]
    public void ToKebabCaseTest()
    {
        // Arrange
        var input = "Kebab Case Extensions";
        var expected = "kebab-case-extensions";

        // Act
        var result = input.ToKebabCase();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FromPascalCase_ToKebabCase()
    {
        // Arrange
        var input = "KebabCaseExtensions";
        var expected = "kebab-case-extensions";

        // Act
        var result = input.ToKebabCase();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FromCamelCase_ToKebabCase()
    {
        // Arrange
        var input = "kebabCaseExtensions";
        var expected = "kebab-case-extensions";

        // Act
        var result = input.ToKebabCase();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FromTrainCase_ToKebabCase()
    {
        // Arrange
        var input = "Kebab-Case-Extensions";
        var expected = "kebab-case-extensions";

        // Act
        var result = input.ToKebabCase();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FromSnakeCase_ToKebabCase()
    {
        // Arrange
        var input = "kebab_case_extensions";
        var expected = "kebab-case-extensions";

        // Act
        var result = input.ToKebabCase();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FromKebabCase_ToKebabCase()
    {
        // Arrange
        var input = "kebab-case-extensions";
        var expected = "kebab-case-extensions";

        // Act
        var result = input.ToKebabCase();

        // Assert
        Assert.AreEqual(expected, result);
    }
}
