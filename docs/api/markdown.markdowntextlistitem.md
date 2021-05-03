[`< Back`](./)

---

# MarkdownTextListItem

Namespace: Markdown

Markdown text list item.

```csharp
public class MarkdownTextListItem : MarkdownTextElement, IMarkdownListItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownTextListItem](./markdown.markdowntextlistitem)<br>
Implements [IMarkdownListItem](./markdown.imarkdownlistitem)

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

### **MarkdownTextListItem(String)**

Initializes a new instance of the [MarkdownTextListItem](./markdown.markdowntextlistitem) class.

```csharp
public MarkdownTextListItem(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The list item text.

### **MarkdownTextListItem(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownTextListItem](./markdown.markdowntextlistitem) class.

```csharp
public MarkdownTextListItem(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The list item text as markdown inline element.

## Methods

### **ToString()**

Returns a string that represents the current markdown text list item.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown text list item.

---

[`< Back`](./)
