[`< Back`](./)

---

# MarkdownTableHeader

Namespace: Markdown

Markdown table header.

```csharp
public class MarkdownTableHeader
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTableHeader](./markdown.markdowntableheader)

## Properties

### **Cells**

Gets the cells.

```csharp
public MarkdownTableHeaderCell[] Cells { get; }
```

#### Property Value

[MarkdownTableHeaderCell[]](./markdown.markdowntableheadercell)<br>
The cells.

## Constructors

### **MarkdownTableHeader(MarkdownTableHeaderCell[])**

Initializes a new instance of the [MarkdownTableHeader](./markdown.markdowntableheader) class.

```csharp
public MarkdownTableHeader(MarkdownTableHeaderCell[] cells)
```

#### Parameters

`cells` [MarkdownTableHeaderCell[]](./markdown.markdowntableheadercell)<br>
The cells.

### **MarkdownTableHeader(Int32)**

Initializes a new instance of the [MarkdownTableHeader](./markdown.markdowntableheader) class.

```csharp
public MarkdownTableHeader(int capacity)
```

#### Parameters

`capacity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The header cell capacity.

## Methods

### **ToString()**

Returns a string that represents the current markdown table header.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown table header.

---

[`< Back`](./)
