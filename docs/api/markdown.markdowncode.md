[`< Back`](./)

---

# MarkdownCode

Namespace: Markdown

Markdown code.

```csharp
public class MarkdownCode : MarkdownTextElement, IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownCode](./markdown.markdowncode)<br>
Implements [IMarkdownBlockElement](./markdown.imarkdownblockelement)

## Properties

### **Language**

Gets or sets the code language.

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Code language.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownCode(String, String)**

Initializes a new instance of the [MarkdownCode](./markdown.markdowncode) class.

```csharp
public MarkdownCode(string language, string code)
```

#### Parameters

`language` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code language.

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code.

### **MarkdownCode(String, MarkdownInlineElement)**

Initializes a new instance of the [MarkdownCode](./markdown.markdowncode) class.

```csharp
public MarkdownCode(string language, MarkdownInlineElement inlineElement)
```

#### Parameters

`language` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code language.

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
