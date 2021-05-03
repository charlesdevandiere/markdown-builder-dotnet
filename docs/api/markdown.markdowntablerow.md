[`< Back`](./)

---

# MarkdownTableRow

Namespace: Markdown

Markdown table row.

```csharp
public class MarkdownTableRow
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTableRow](./markdown.markdowntablerow)

## Properties

### **Cells**

Gets the cells.

```csharp
public MarkdownInlineElement[] Cells { get; }
```

#### Property Value

[MarkdownInlineElement[]](./markdown.markdowninlineelement)<br>
The cells.

## Constructors

### **MarkdownTableRow(IEnumerable&lt;MarkdownInlineElement&gt;)**

Initializes a new instance of the [MarkdownTableRow](./markdown.markdowntablerow) class.

```csharp
public MarkdownTableRow(IEnumerable<MarkdownInlineElement> cells)
```

#### Parameters

`cells` [IEnumerable&lt;MarkdownInlineElement&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The cells.

### **MarkdownTableRow(MarkdownInlineElement[])**

Initializes a new instance of the [MarkdownTableRow](./markdown.markdowntablerow) class.

```csharp
public MarkdownTableRow(MarkdownInlineElement[] cells)
```

#### Parameters

`cells` [MarkdownInlineElement[]](./markdown.markdowninlineelement)<br>
The cells.

### **MarkdownTableRow(IEnumerable&lt;String&gt;)**

Initializes a new instance of the [MarkdownTableRow](./markdown.markdowntablerow) class.

```csharp
public MarkdownTableRow(IEnumerable<string> cells)
```

#### Parameters

`cells` [IEnumerable&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The cells.

### **MarkdownTableRow(String[])**

Initializes a new instance of the [MarkdownTableRow](./markdown.markdowntablerow) class.

```csharp
public MarkdownTableRow(String[] cells)
```

#### Parameters

`cells` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The cells.

### **MarkdownTableRow(Int32)**

Initializes a new instance of the [MarkdownTableRow](./markdown.markdowntablerow) class.

```csharp
public MarkdownTableRow(int capacity)
```

#### Parameters

`capacity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The capacity.

## Methods

### **ToString()**

Returns a string that represents the current markdown table row.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown table row.

---

[`< Back`](./)
