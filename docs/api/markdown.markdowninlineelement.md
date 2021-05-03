[`< Back`](./)

---

# MarkdownInlineElement

Namespace: Markdown

Markdown inline element.

```csharp
public abstract class MarkdownInlineElement : MarkdownTextElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement)

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

### **MarkdownInlineElement(String)**

Initializes a new instance of the [MarkdownInlineElement](./markdown.markdowninlineelement) class.

```csharp
public MarkdownInlineElement(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The inline element text.

### **MarkdownInlineElement(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownInlineElement](./markdown.markdowninlineelement) class.

```csharp
public MarkdownInlineElement(MarkdownInlineElement element)
```

#### Parameters

`element` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The inline element text as markdown inline element.

---

[`< Back`](./)
