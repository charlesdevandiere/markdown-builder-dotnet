# MarkdownList

`Namespace: Markdown`

Markdown list.

```csharp
public class MarkdownList
    : IMarkdownListItem, IMarkdownBlockElement
```

## Properties

| Type | Name | Summary |
| --- | --- | --- |
| `Char` | Char | Gets or sets the bullet point character. |
| `List<IMarkdownListItem>` | ListItems | Gets the list items. |

## Methods

| Type | Name | Summary |
| --- | --- | --- |
| `String` | PrintBulletPoint(`Int32` index) | Prints the bullet point. |
| `String` | ToString() | Returns a string that represents the current markdown list. |

---

[`< Back`](../)
