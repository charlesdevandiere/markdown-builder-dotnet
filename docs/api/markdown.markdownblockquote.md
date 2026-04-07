[`< Back`](./)

---

# MarkdownBlockquote

Namespace: Markdown

Markdown blockquote. Can contain any block elements (paragraphs, lists, code blocks, other blockquotes).

```csharp
public class MarkdownBlockquote : IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownBlockquote](./markdown.markdownblockquote)<br>
Implements [IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
Attributes [NullableContextAttribute](./system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](./system.runtime.compilerservices.nullableattribute)

## Properties

### **BlockElements**

Gets the block elements contained in the blockquote.

```csharp
public List<IMarkdownBlockElement> BlockElements { get; }
```

#### Property Value

[List&lt;IMarkdownBlockElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
The block elements.

## Constructors

### **MarkdownBlockquote(IMarkdownBlockElement[])**

Initializes a new instance of the [MarkdownBlockquote](./markdown.markdownblockquote) class.

```csharp
public MarkdownBlockquote(IMarkdownBlockElement[] elements)
```

#### Parameters

`elements` [IMarkdownBlockElement[]](./markdown.imarkdownblockelement)<br>
The block elements.

### **MarkdownBlockquote(IEnumerable&lt;IMarkdownBlockElement&gt;)**

Initializes a new instance of the [MarkdownBlockquote](./markdown.markdownblockquote) class.

```csharp
public MarkdownBlockquote(IEnumerable<IMarkdownBlockElement> elements)
```

#### Parameters

`elements` [IEnumerable&lt;IMarkdownBlockElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The block elements.

### **MarkdownBlockquote(String)**

Initializes a new instance of the [MarkdownBlockquote](./markdown.markdownblockquote) class with a text paragraph.

```csharp
public MarkdownBlockquote(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The blockquote text.

### **MarkdownBlockquote(MarkdownInlineElement)**

Initializes a new instance of the [MarkdownBlockquote](./markdown.markdownblockquote) class with an inline element paragraph.

```csharp
public MarkdownBlockquote(MarkdownInlineElement inlineElement)
```

#### Parameters

`inlineElement` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The blockquote text as markdown inline element.

## Methods

### **ToString()**

Returns a string that represents the current markdown blockquote.
 Each line of the contained block elements is prefixed with "&gt; ".

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown blockquote.

---

[`< Back`](./)
