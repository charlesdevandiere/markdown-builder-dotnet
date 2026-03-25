[`< Back`](./)

---

# MarkdownStrikethrough

Namespace: Markdown

Markdown strikethrough.

```csharp
public class MarkdownStrikethrough : MarkdownInlineElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownStrikethrough](./markdown.markdownstrikethrough)<br>
Attributes [NullableContextAttribute](./system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](./system.runtime.compilerservices.nullableattribute)

## Properties

### **InlineElement**

Gets or sets the markdown inline element.

```csharp
protected MarkdownInlineElement InlineElement { get; set; }
```

#### Property Value

[MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The markdown inline element.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownStrikethrough(String)**

Initializes a new instance of the [MarkdownStrikethrough](./markdown.markdownstrikethrough) class.

```csharp
public MarkdownStrikethrough(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The strikethrough text.

### **MarkdownStrikethrough(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownStrikethrough](./markdown.markdownstrikethrough) class.

```csharp
public MarkdownStrikethrough(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The strikethrough text as markdown inline element.

## Methods

### **ToString()**

Returns a string that represents the current markdown strikethrough.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown strikethrough.

---

[`< Back`](./)
