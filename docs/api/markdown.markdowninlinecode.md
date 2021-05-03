[`< Back`](./)

---

# MarkdownInlineCode

Namespace: Markdown

Markdown inline code.

```csharp
public class MarkdownInlineCode : MarkdownInlineElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownInlineCode](./markdown.markdowninlinecode)

## Properties

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownInlineCode(String)**

Initializes a new instance of the [MarkdownInlineCode](./markdown.markdowninlinecode) class.

```csharp
public MarkdownInlineCode(string code)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code.

### **MarkdownInlineCode(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownInlineCode](./markdown.markdowninlinecode) class.

```csharp
public MarkdownInlineCode(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The code as markdown inline element.

## Methods

### **ToString()**

Returns a string that represents the current markdown code.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown code.

---

[`< Back`](./)
