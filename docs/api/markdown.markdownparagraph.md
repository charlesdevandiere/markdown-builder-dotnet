[`< Back`](./)

---

# MarkdownParagraph

Namespace: Markdown

Markdown paragraph.

```csharp
public class MarkdownParagraph : MarkdownTextElement, IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownParagraph](./markdown.markdownparagraph)<br>
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

### **MarkdownParagraph(String)**

Initializes a new instance of the [MarkdownParagraph](./markdown.markdownparagraph) class.

```csharp
public MarkdownParagraph(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The paragraph text.

### **MarkdownParagraph(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownParagraph](./markdown.markdownparagraph) class.

```csharp
public MarkdownParagraph(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The paragraph text as markdown inline element.

## Methods

### **ToString()**

Returns a string that represents the current markdown paragraph.
 The paragraph text is trimed.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown paragraph.

---

[`< Back`](./)
