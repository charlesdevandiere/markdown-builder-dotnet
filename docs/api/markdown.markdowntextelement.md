[`< Back`](./)

---

# MarkdownTextElement

Namespace: Markdown

Markdown text element.

```csharp
public abstract class MarkdownTextElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement)<br>
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

### **MarkdownTextElement(String)**

Initializes a new instance of the [MarkdownTextElement](./markdown.markdowntextelement) class.

```csharp
protected MarkdownTextElement(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text.

### **MarkdownTextElement(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownTextElement](./markdown.markdowntextelement) class.

```csharp
protected MarkdownTextElement(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The text as markdown inline element.

---

[`< Back`](./)
