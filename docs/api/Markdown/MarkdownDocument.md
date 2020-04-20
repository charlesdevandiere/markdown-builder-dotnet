# MarkdownDocument

`Namespace: Markdown`

Markdown document.

```csharp
public class MarkdownDocument
    : IMarkdownDocument
```

## Properties

| Type | Name | Summary |
| --- | --- | --- |
| `Int32` | Capacity | Gets or sets the maximum number of markdown block elements that can be contained in the memory allocated by the current instance. |
| `Int32` | Length | Gets the length of the current `Markdown.IMarkdownDocument` object. |

## Methods

| Type | Name | Summary |
| --- | --- | --- |
| `IMarkdownDocument` | Append(`IMarkdownBlockElement` blockElement) | Appends the specified block element. |
| `IMarkdownDocument` | Clear() | Clears this markdown document. |
| `IMarkdownBlockElement` | ElementAt(`Int32` index) | Returns the specified block element at index. |
| `Int32` | IndexOf(`IMarkdownBlockElement` blockElement) | Returns the specified block element index. |
| `IMarkdownDocument` | Insert(`Int32` index, `IMarkdownBlockElement` blockElement) | Inserts the specified block element into this instance at a specified position. |
| `IMarkdownDocument` | Remove(`Int32` index) | Removes the specified block element at index. |
| `IMarkdownDocument` | Remove(`IMarkdownBlockElement` blockElement) | Removes the specified block element at index. |
| `IMarkdownDocument` | Replace(`IMarkdownBlockElement` oldBlockElement, `IMarkdownBlockElement` newBlockElement) | Replaces all occurrences of a specified block element in this instance with another specified block element. |
| `String` | ToString() | Returns a string that represents the current markdown document. |

---

[`< Back`](../)
