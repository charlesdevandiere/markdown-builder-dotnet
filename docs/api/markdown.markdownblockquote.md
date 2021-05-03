[`< Back`](./)

---

# MarkdownBlockquote

Namespace: Markdown

Markdown blockquote.

```csharp
public class MarkdownBlockquote : MarkdownTextElement, IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownBlockquote](./markdown.markdownblockquote)<br>
Implements [IMarkdownBlockElement](./markdown.imarkdownblockelement)

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

### **MarkdownBlockquote(String)**

Initializes a new instance of [MarkdownBlockquote](./markdown.markdownblockquote) class.

```csharp
public MarkdownBlockquote(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The blockquote text.

### **MarkdownBlockquote(MarkdownInlineElement)**

Initializes a new instance of [MarkdownBlockquote](./markdown.markdownblockquote) class.

```csharp
public MarkdownBlockquote(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The blockquote text as markdown inline element.

## Methods

### **ToString()**

Returns a string that represents the current markdown blockquote.
 The blockquote text is trimed.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown blockquote.

---

[`< Back`](./)
