[`< Back`](./)

---

# MarkdownStrongEmphasis

Namespace: Markdown

Markdown strong emphasis.

```csharp
public class MarkdownStrongEmphasis : MarkdownInlineElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownStrongEmphasis](./markdown.markdownstrongemphasis)

## Properties

### **Char**

Gets or sets the strong emphasis character.

```csharp
public char Char { get; private set; }
```

#### Property Value

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
Strong emphasis character.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownStrongEmphasis(String, Char)**

Initializes a new instance of the [MarkdownStrongEmphasis](./markdown.markdownstrongemphasis) class.

```csharp
public MarkdownStrongEmphasis(string text, char char)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The strong emphasis text.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The strong emphasis character. Default is '*'.

### **MarkdownStrongEmphasis(MarkdownInlineElement, Char)**

Initializes a new instance of the [MarkdownStrongEmphasis](./markdown.markdownstrongemphasis) class.

```csharp
public MarkdownStrongEmphasis(MarkdownInlineElement inlineElement, char char)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The strong emphasis text as markdown inline element.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The strong emphasis character. Default is '*'.

## Methods

### **ToString()**

Returns a string that represents the current markdown strong emphasis.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown strong emphasis.

---

[`< Back`](./)
