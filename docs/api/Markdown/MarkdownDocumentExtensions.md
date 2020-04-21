# MarkdownDocumentExtensions

`Namespace: Markdown`

Markdown document extensions.

```csharp
public static class MarkdownDocumentExtensions
```

## Static Methods

| Type | Name | Summary |
| --- | --- | --- |
| `IMarkdownDocument` | AppendBlockquote(this `IMarkdownDocument` document, `String` text) | Creates a blockquote with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendBlockquote(this `IMarkdownDocument` document, `MarkdownInlineElement` text) | Creates a blockquote with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendCode(this `IMarkdownDocument` document, `String` language, `String` code) | Creates a code block with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendCode(this `IMarkdownDocument` document, `String` language, `MarkdownInlineElement` code) | Creates a code block with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendHeader(this `IMarkdownDocument` document, `String` header, `Int32` level) | Creates an header with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendHeader(this `IMarkdownDocument` document, `MarkdownInlineElement` header, `Int32` level) | Creates an header with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendHorizontalRule(this `IMarkdownDocument` document) | Creates an horizontal rule and appends this to the document. |
| `IMarkdownDocument` | AppendHorizontalRule(this `IMarkdownDocument` document, `Char` char) | Creates an horizontal rule and appends this to the document. |
| `IMarkdownDocument` | AppendList(this `IMarkdownDocument` document, `String[]` items) | Creates a list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendList(this `IMarkdownDocument` document, `IMarkdownListItem[]` items) | Creates a list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendList(this `IMarkdownDocument` document, `IEnumerable<IMarkdownListItem>` items) | Creates a list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendList(this `IMarkdownDocument` document, `Char` char, `String[]` items) | Creates a list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendList(this `IMarkdownDocument` document, `Char` char, `IMarkdownListItem[]` items) | Creates a list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendList(this `IMarkdownDocument` document, `Char` char, `IEnumerable<IMarkdownListItem>` items) | Creates a list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendOrderedList(this `IMarkdownDocument` document, `String[]` items) | Creates an ordered list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendOrderedList(this `IMarkdownDocument` document, `MarkdownTextListItem[]` items) | Creates an ordered list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendOrderedList(this `IMarkdownDocument` document, `IEnumerable<MarkdownTextListItem>` items) | Creates an ordered list with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendParagraph(this `IMarkdownDocument` document, `String` text) | Creates a paragraph with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendParagraph(this `IMarkdownDocument` document, `MarkdownInlineElement` text) | Creates a paragraph with the specified arguments and appends this to the document. |
| `IMarkdownDocument` | AppendTable(this `IMarkdownDocument` document, `MarkdownTableHeader` header, `IEnumerable<MarkdownTableRow>` rows) | Creates a table with the specified arguments and appends this to the document. |

---

[`< Back`](../)
