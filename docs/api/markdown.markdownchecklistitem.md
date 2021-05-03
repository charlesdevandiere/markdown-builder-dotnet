[`< Back`](./)

---

# MarkdownCheckListItem

Namespace: Markdown

Markdown check list item.

```csharp
public class MarkdownCheckListItem : MarkdownTextListItem, IMarkdownListItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownTextListItem](./markdown.markdowntextlistitem) → [MarkdownCheckListItem](./markdown.markdownchecklistitem)<br>
Implements [IMarkdownListItem](./markdown.imarkdownlistitem)

## Properties

### **Checked**

Gets or sets the item state.

```csharp
public bool Checked { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
true if the item is checked; otherwise, false. The default is false.

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text or a string that represents the markdown inline element.

## Constructors

### **MarkdownCheckListItem(Boolean, String)**

Initializes a new instance of the [MarkdownCheckListItem](./markdown.markdownchecklistitem) class.

```csharp
public MarkdownCheckListItem(bool checked, string text)
```

#### Parameters

`checked` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
The item state.

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The item text.

### **MarkdownCheckListItem(Boolean, MarkdownInlineElement)**

Initializes a new instance of the [MarkdownCheckListItem](./markdown.markdownchecklistitem) class.

```csharp
public MarkdownCheckListItem(bool checked, MarkdownInlineElement element)
```

#### Parameters

`checked` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
The item state.

`element` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The item text as markdown inline element.

## Methods

### **ToString()**

Returns a string that represents the current markdown check list item.
 The check list item text is trimed.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown check list item.

---

[`< Back`](./)
