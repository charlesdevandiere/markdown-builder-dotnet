[`< Back`](./)

---

# MarkdownText

Namespace: Markdown

Markdown text.

```csharp
public class MarkdownText : MarkdownInlineElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownText](./markdown.markdowntext)

## Properties

### **Text**

Gets or sets the text.

```csharp
public string Text { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown text.

## Constructors

### **MarkdownText(String)**

Initializes a new instance of the [MarkdownText](./markdown.markdowntext) class.

```csharp
public MarkdownText(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text.

### **MarkdownText(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownText](./markdown.markdowntext) class.

```csharp
public MarkdownText(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The text as markdown inline element.

## Methods

### **Append(String)**

Appends the specified text to this instance.

```csharp
public MarkdownText Append(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text to append.

#### Returns

[MarkdownText](./markdown.markdowntext)<br>
The markdown text.

### **Append(MarkdownInlineElement)**

Appends the specified markdown inline element to this instance.

```csharp
public MarkdownText Append(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The markdown inline element to append.

#### Returns

[MarkdownText](./markdown.markdowntext)<br>
The markdown text.

### **ToString()**

Returns a string that represents the current markdown text.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown text.

---

[`< Back`](./)
