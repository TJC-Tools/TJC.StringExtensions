![GitHub Tag](https://img.shields.io/github/v/tag/TJC-Tools/TJC.StringExtensions) [![GitHub Release](https://img.shields.io/github/v/release/TJC-Tools/TJC.StringExtensions)](https://github.com/TJC-Tools/TJC.StringExtensions/releases/latest) [![NuGet Version](https://img.shields.io/nuget/v/TJC.StringExtensions)](https://www.nuget.org/packages/TJC.StringExtensions)

[![NuGet Downloads](https://img.shields.io/nuget/dt/TJC.StringExtensions)](https://www.nuget.org/packages/TJC.StringExtensions) ![Size](https://img.shields.io/github/repo-size/TJC-Tools/TJC.StringExtensions) [![License](https://img.shields.io/github/license/TJC-Tools/TJC.StringExtensions.svg)](LICENSE)

[![codecov](https://codecov.io/gh/TJC-Tools/TJC.StringExtensions/graph/badge.svg?token=RJ4DWNQ7S5)](https://codecov.io/gh/TJC-Tools/TJC.StringExtensions)

## Table of Contents
- [Pluralize](#pluralize)
- [Separator](#separator)
- [Parsing](#parsing)
- [Lines](#lines)
- [Padding](#padding)

---

## Pluralize

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[Pluralize](./TJC.StringExtensions/Pluralize/PluralizeExtensions.cs)(int number, string? pluralized = null)
- Takes a string and pluralizes it based on the number provided.
```c#
var item = "apple";
var plural = item.Pluralize(2);
Console.WriteLine(plural); // apples
```

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-8.0)\<object\>.[Pluralize](./TJC.StringExtensions/Pluralize/PluralizeExtensions.cs)(string nonPluralized, string? pluralized = null)
- Takes a collection of objects and pluralizes a string based on the number of objects in the collection.
```c#
// Multiple items in a collection results in a pluralized string
var itemsMultiple = new List<string> { "item1", "item2", "item3" };
var plural = itemsMultiple.Pluralize("item");
Console.WriteLine(plural); // items

// A single item in a collection results in a singular string
var itemsSingle = new List<string> { "item1" };
var singluar = itemsSingle.Pluralize("item");
Console.WriteLine(singluar); // item
```

---

## Separator

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-8.0)\<[string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0)\>.[JoinComma](./TJC.StringExtensions/Separator/SeparatorExtensions.cs)()
- Joins a collection of strings with a comma and space.
```c#
var items = new List<string> { "one", "two", "three" };
var result = items.JoinComma(); // one, two, three
```

---

## Parsing

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[KeepAlpha](./TJC.StringExtensions/Parsing/StringParserExtensions.cs)()
- Keep letters only.
```c#
// Arrange
var input = "a1!b2@c3#.d4$ e5%";
var result = input.KeepAlpha(); // abcde
```

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[KeepNumeric](./TJC.StringExtensions/Parsing/StringParserExtensions.cs)()
- Keep numbers only.
```c#
// Arrange
var input = "a1!b2@c3#.d4$ e5%";
var result = input.KeepNumeric(); // 12345
```

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[KeepNumericAndPeriod](./TJC.StringExtensions/Parsing/StringParserExtensions.cs)()
- Keep numbers and periods only.
```c#
// Arrange
var input = "a1!b2@c3#.d4$ e5%";
var result = input.KeepNumericAndPeriod(); // 123.45
```

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[KeepAlphaNumeric](./TJC.StringExtensions/Parsing/StringParserExtensions.cs)()
- Keep letters and numbers only.
```c#
// Arrange
var input = "a1!b2@c3#.d4$ e5%";
var result = input.KeepAlphaNumeric(); // a1b2c3d4e5
```

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[KeepAlphaNumericAndSpace](./TJC.StringExtensions/Parsing/StringParserExtensions.cs)()
- Keep letters, numbers, and spaces only.
```c#
// Arrange
var input = "a1!b2@c3#.d4$ e5%";
var result = input.KeepAlphaNumericAndSpace(); // a1b2c3d4 e5
```

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[RemoveSymbols](./TJC.StringExtensions/Parsing/StringParserExtensions.cs)(char[]? exceptions = null)
- Remove symbols from a string, except any exceptions provided.
```c#
// Arrange
var input = "a1!b2@c3#.d4$ e5%";
var result = input.RemoveSymbols(['!', '.']); // a1!b2c3.d4 e5
```

---

## Lines

### [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-8.0)\<[string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0)\> [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[SplitNewLine](./TJC.StringExtensions/Lines/LineExtensions.cs)()
- Splits a string into lines on a new line character.

### [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-8.0)\<[string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0)\> [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[SplitLines](./TJC.StringExtensions/Lines/LineExtensions.cs)(int width = 60, char separator = ' ')
- Splits a string into lines of a max width with a separator character.

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[RemoveMultipleBlankLines](./TJC.StringExtensions/Lines/LineExtensions.cs)()
- Remove multiple blank lines from a string.

---

## Padding

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0).[PadBoth](./TJC.StringExtensions/Padding/PaddingExtensions.cs)([int](https://learn.microsoft.com/en-us/dotnet/api/system.int32?view=net-8.0) length)
- Pads both side of a string so that it's centered between the padding
