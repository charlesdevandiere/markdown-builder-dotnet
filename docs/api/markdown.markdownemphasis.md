[`< Back`](./)

---

# MarkdownEmphasis

Namespace: Markdown

Markdown emphasis.

```csharp
public class MarkdownEmphasis : MarkdownInlineElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownEmphasis](./markdown.markdownemphasis)

## Properties

### **Char**

Gets or sets the emphasis character.

```csharp
public char Char { get; set; }
```

#### Property Value

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
Emphasis character.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownEmphasis(String)**

Initializes a new instance of the [MarkdownEmphasis](./markdown.markdownemphasis) class.

```csharp
public MarkdownEmphasis(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The emphasis text.

### **MarkdownEmphasis(String, Char)**

Initializes a new instance of the [MarkdownEmphasis](./markdown.markdownemphasis) class.

```csharp
public MarkdownEmphasis(string text, char char)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The emphasis text.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The emphasis character.

### **MarkdownEmphasis(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownEmphasis](./markdown.markdownemphasis) class.

```csharp
public MarkdownEmphasis(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The emphasis text as markdown inline element.

### **MarkdownEmphasis(MarkdownInlineElement, Char)**

Initializes a new instance of the [MarkdownEmphasis](./markdown.markdownemphasis) class.

```csharp
public MarkdownEmphasis(MarkdownInlineElement inlineElement, char char)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The emphasis text as markdown inline element.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The emphasis character.

## Methods

### **ToString()**

Returns a string that represents the current markdown emphasis.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown emphasis.

---

[`< Back`](./)
