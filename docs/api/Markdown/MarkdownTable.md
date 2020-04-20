# MarkdownTable

`Namespace: Markdown`

Markdown table.

```csharp
public class MarkdownTable
    : IMarkdownBlockElement
```

## Properties

| Type | Name | Summary |
| --- | --- | --- |
| `Int32` | ColumnCount | Gets the number of columns. |
| `MarkdownTableHeader` | Header | Gets the header. |
| `Int32` | RowsCapacity | Gets or sets the rows capacity. |
| `Int32` | RowsCount | Gets the number of rows. |

## Methods

| Type | Name | Summary |
| --- | --- | --- |
| `void` | AddRow(`MarkdownTableRow` row) | Adds the specific row at the end of the table. |
| `void` | AddRowRange(`IEnumerable<MarkdownTableRow>` rows) | Adds the specific rows at the end of the table. |
| `MarkdownTableRow` | GetRowAt(`Int32` index) | Gets the row at the specific index. |
| `void` | RemoveRowAt(`Int32` index) | Remove the row at the specific index. |
| `String` | ToString() | Returns a string that represents the current markdown table. |

---

[`< Back`](../)
