[`< Back`](./)

---

# MarkdownTableTextAlignmentExtensions

Namespace: Markdown

Markdown table text alignment extensions.

```csharp
public static class MarkdownTableTextAlignmentExtensions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTableTextAlignmentExtensions](./markdown.markdowntabletextalignmentextensions)<br>
Attributes [NullableContextAttribute](./system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](./system.runtime.compilerservices.nullableattribute), [ExtensionAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

## Methods

### **Print(MarkdownTableTextAlignment)**

Prints the specified text alignment.

```csharp
public static string Print(MarkdownTableTextAlignment textAlignment)
```

#### Parameters

`textAlignment` [MarkdownTableTextAlignment](./markdown.markdowntabletextalignment)<br>
The text alignment.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown table text alignment.

### **Print(MarkdownTableTextAlignment, Int32)**

Prints the specified text alignment padded to the given width.

```csharp
public static string Print(MarkdownTableTextAlignment textAlignment, int width)
```

#### Parameters

`textAlignment` [MarkdownTableTextAlignment](./markdown.markdowntabletextalignment)<br>
The text alignment.

`width` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The column width (minimum 3).

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A padded string that represents the current markdown table text alignment.

---

[`< Back`](./)
