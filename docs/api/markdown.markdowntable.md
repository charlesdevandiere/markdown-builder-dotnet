[`< Back`](./)

---

# MarkdownTable

Namespace: Markdown

Markdown table.

```csharp
public class MarkdownTable : IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownTable](./markdown.markdowntable)<br>
Implements [IMarkdownBlockElement](./markdown.imarkdownblockelement)

## Properties

### **Header**

Gets the header.

```csharp
public MarkdownTableHeader Header { get; }
```

#### Property Value

[MarkdownTableHeader](./markdown.markdowntableheader)<br>
The header.

### **ColumnCount**

Gets the number of columns.

```csharp
public int ColumnCount { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **RowsCount**

Gets the number of rows.

```csharp
public int RowsCount { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **RowsCapacity**

Gets or sets the rows capacity.

```csharp
public int RowsCapacity { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The rows capacity.

## Constructors

### **MarkdownTable(MarkdownTableHeader)**

Initializes a new instance of the [MarkdownTable](./markdown.markdowntable) class.

```csharp
public MarkdownTable(MarkdownTableHeader header)
```

#### Parameters

`header` [MarkdownTableHeader](./markdown.markdowntableheader)<br>
The header.

### **MarkdownTable(MarkdownTableHeader, IEnumerable&lt;MarkdownTableRow&gt;)**

Initializes a new instance of the [MarkdownTable](./markdown.markdowntable) class.

```csharp
public MarkdownTable(MarkdownTableHeader header, IEnumerable<MarkdownTableRow> rows)
```

#### Parameters

`header` [MarkdownTableHeader](./markdown.markdowntableheader)<br>
The header.

`rows` [IEnumerable&lt;MarkdownTableRow&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The rows.

### **MarkdownTable(MarkdownTableHeader, Int32)**

Initializes a new instance of the [MarkdownTable](./markdown.markdowntable) class.

```csharp
public MarkdownTable(MarkdownTableHeader header, int capacity)
```

#### Parameters

`header` [MarkdownTableHeader](./markdown.markdowntableheader)<br>
The header.

`capacity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The row capacity.

## Methods

### **AddRow(MarkdownTableRow)**

Adds the specific row at the end of the table.

```csharp
public void AddRow(MarkdownTableRow row)
```

#### Parameters

`row` [MarkdownTableRow](./markdown.markdowntablerow)<br>
The row to be added.

### **AddRowRange(IEnumerable&lt;MarkdownTableRow&gt;)**

Adds the specific rows at the end of the table.

```csharp
public void AddRowRange(IEnumerable<MarkdownTableRow> rows)
```

#### Parameters

`rows` [IEnumerable&lt;MarkdownTableRow&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The rows to be added.

### **GetRowAt(Int32)**

Gets the row at the specific index.

```csharp
public MarkdownTableRow GetRowAt(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The row index.

#### Returns

[MarkdownTableRow](./markdown.markdowntablerow)<br>
The row

### **RemoveRowAt(Int32)**

Remove the row at the specific index.

```csharp
public void RemoveRowAt(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The row index.

### **ToString()**

Returns a string that represents the current markdown table.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown table.

---

[`< Back`](./)
