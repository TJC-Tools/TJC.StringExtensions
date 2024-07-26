[![NuGet Version and Downloads count](https://buildstats.info/nuget/TJC.StringExtensions)](https://www.nuget.org/packages/TJC.StringExtensions)

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

### [string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0) [JoinComma](./TJC.StringExtensions/Separator/SeparatorExtensions.cs)(this [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-8.0)\<[string](https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0)\> strings)
- Joins a collection of strings with a comma and space.
```c#
var items = new List<string> { "one", "two", "three" };
var result = items.JoinComma(); // one, two, three
```
