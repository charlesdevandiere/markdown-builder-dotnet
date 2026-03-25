[`< Back`](./)

---

# MarkdownTableHeaderCell

Namespace: Markdown

Markdown table header cell.

```csharp
public class MarkdownTableHeaderCell : MarkdownTextElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTextElement](./markdown.markdowntextelement) → [MarkdownTableHeaderCell](./markdown.markdowntableheadercell)<br>
Attributes [NullableContextAttribute](./system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](./system.runtime.compilerservices.nullableattribute)

## Properties

### **ColumnTextAlignment**

Gets or sets the column text alignment.

```csharp
public MarkdownTableTextAlignment ColumnTextAlignment { get; set; }
```

#### Property Value

[MarkdownTableTextAlignment](./markdown.markdowntabletextalignment)<br>
The column text alignment.

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

### **MarkdownTableHeaderCell(String)**

Initializes a new instance of the [MarkdownTableHeaderCell](./markdown.markdowntableheadercell) class.

```csharp
public MarkdownTableHeaderCell(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The header cell text.

### **MarkdownTableHeaderCell(String, MarkdownTableTextAlignment)**

Initializes a new instance of the [MarkdownTableHeaderCell](./markdown.markdowntableheadercell) class.

```csharp
public MarkdownTableHeaderCell(string text, MarkdownTableTextAlignment textAlignment)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The header cell text.

`textAlignment` [MarkdownTableTextAlignment](./markdown.markdowntabletextalignment)<br>
The column text alignment.

### **MarkdownTableHeaderCell(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownTableHeaderCell](./markdown.markdowntableheadercell) class.

```csharp
public MarkdownTableHeaderCell(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The header cell text as markdown inline element.

### **MarkdownTableHeaderCell(MarkdownInlineElement, MarkdownTableTextAlignment)**

Initializes a new instance of the [MarkdownTableHeaderCell](./markdown.markdowntableheadercell) class.

```csharp
public MarkdownTableHeaderCell(MarkdownInlineElement inlineElement, MarkdownTableTextAlignment textAlignment)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The header cell text as markdown inline element.

`textAlignment` [MarkdownTableTextAlignment](./markdown.markdowntabletextalignment)<br>
The column text alignment.

---

[`< Back`](./)
