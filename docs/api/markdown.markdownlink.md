[`< Back`](./)

---

# MarkdownLink

Namespace: Markdown

Markdown link.

```csharp
public class MarkdownLink : MarkdownInlineElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownLink](./markdown.markdownlink)

## Properties

### **Url**

Gets or sets the link URL.

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Link URL.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownLink(String, String)**

Initializes a new instance of the [MarkdownLink](./markdown.markdownlink) class.

```csharp
public MarkdownLink(string text, string url)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The link text.

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The link URL.

### **MarkdownLink(MarkdownInlineElement, String)**

Initializes a new instance of the [MarkdownLink](./markdown.markdownlink) class.

```csharp
public MarkdownLink(MarkdownInlineElement inlineElement, string url)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The link text as markdown inline element.

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The link URL.

## Methods

### **ToString()**

Returns a string that represents the current markdown link.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown link.

---

[`< Back`](./)
