[`< Back`](./)

---

# MarkdownEmoji

Namespace: Markdown

Markdown emoji.

```csharp
public class MarkdownEmoji : MarkdownInlineElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownEmoji](./markdown.markdownemoji)

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

### **MarkdownEmoji(String)**

Initializes a new instance of the [MarkdownEmoji](./markdown.markdownemoji) class.

```csharp
public MarkdownEmoji(string code)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The emoji code.

## Methods

### **ToString()**

Returns a string that represents the current markdown emoji code.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown emoji code.

---

[`< Back`](./)
