[`< Back`](./)

---

# MarkdownHeader

Namespace: Markdown

Markdown header.

```csharp
public class MarkdownHeader : MarkdownTextElement, IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownHeader](./markdown.markdownheader)<br>
Implements [IMarkdownBlockElement](./markdown.imarkdownblockelement)

## Properties

### **Level**

Gets or sets the header level.

```csharp
public int Level { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The header level.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownHeader(String, Int32)**

Initializes a new instance of the [MarkdownHeader](./markdown.markdownheader) class.

```csharp
public MarkdownHeader(string header, int level)
```

#### Parameters

`header` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The header text.

`level` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The header level.

### **MarkdownHeader(MarkdownInlineElement, Int32)**

Initializes a new instance of the [MarkdownHeader](./markdown.markdownheader) class.

```csharp
public MarkdownHeader(MarkdownInlineElement inlineElement, int level)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The header text as markdown inline element.

`level` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The header level.

## Methods

### **ToString()**

Returns a string that represents the current markdown header.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown header.

---

[`< Back`](./)
