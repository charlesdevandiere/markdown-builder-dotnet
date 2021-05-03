[`< Back`](./)

---

# MarkdownImage

Namespace: Markdown

Markdown image.

```csharp
public class MarkdownImage : MarkdownLink
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownInlineElement](./markdown.markdowninlineelement) → [MarkdownLink](./markdown.markdownlink) → [MarkdownImage](./markdown.markdownimage)

## Properties

### **Url**

Gets or sets the link URL.

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Link URL.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownImage(String, String)**

Initializes a new instance of the [MarkdownImage](./markdown.markdownimage) class.

```csharp
public MarkdownImage(string altText, string imageUrl)
```

#### Parameters

`altText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The alternative text.

`imageUrl` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The image URL.

## Methods

### **ToString()**

Returns a string that represents the current markdown image.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown image.

---

[`< Back`](./)
