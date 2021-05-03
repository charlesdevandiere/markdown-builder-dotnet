[`< Back`](./)

---

# MarkdownDocumentExtensions

Namespace: Markdown

Markdown document extensions.

```csharp
public static class MarkdownDocumentExtensions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownDocumentExtensions](./markdown.markdowndocumentextensions)

## Methods

### **AppendHeader(IMarkdownDocument, String, Int32)**

Creates an header with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendHeader(IMarkdownDocument document, string header, int level)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`header` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The header text.

`level` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The header level.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendHeader(IMarkdownDocument, MarkdownInlineElement, Int32)**

Creates an header with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendHeader(IMarkdownDocument document, MarkdownInlineElement header, int level)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`header` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The header text.

`level` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The header level.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendParagraph(IMarkdownDocument, String)**

Creates a paragraph with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendParagraph(IMarkdownDocument document, string text)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The paragraph text.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendParagraph(IMarkdownDocument, MarkdownInlineElement)**

Creates a paragraph with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendParagraph(IMarkdownDocument document, MarkdownInlineElement text)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`text` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The paragraph text.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendHorizontalRule(IMarkdownDocument)**

Creates an horizontal rule and appends this to the document.

```csharp
public static IMarkdownDocument AppendHorizontalRule(IMarkdownDocument document)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendHorizontalRule(IMarkdownDocument, Char)**

Creates an horizontal rule with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendHorizontalRule(IMarkdownDocument document, char char)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The horizontal rule character.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendList(IMarkdownDocument, String[])**

Creates a list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendList(IMarkdownDocument document, String[] items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`items` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendList(IMarkdownDocument, IMarkdownListItem[])**

Creates a list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendList(IMarkdownDocument document, IMarkdownListItem[] items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`items` [IMarkdownListItem[]](./markdown.imarkdownlistitem)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendList(IMarkdownDocument, IEnumerable&lt;IMarkdownListItem&gt;)**

Creates a list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendList(IMarkdownDocument document, IEnumerable<IMarkdownListItem> items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`items` [IEnumerable&lt;IMarkdownListItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendList(IMarkdownDocument, Char, String[])**

Creates a list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendList(IMarkdownDocument document, char char, String[] items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

`items` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendList(IMarkdownDocument, Char, IMarkdownListItem[])**

Creates a list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendList(IMarkdownDocument document, char char, IMarkdownListItem[] items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

`items` [IMarkdownListItem[]](./markdown.imarkdownlistitem)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendList(IMarkdownDocument, Char, IEnumerable&lt;IMarkdownListItem&gt;)**

Creates a list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendList(IMarkdownDocument document, char char, IEnumerable<IMarkdownListItem> items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

`items` [IEnumerable&lt;IMarkdownListItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendOrderedList(IMarkdownDocument, String[])**

Creates an ordered list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendOrderedList(IMarkdownDocument document, String[] items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`items` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendOrderedList(IMarkdownDocument, MarkdownTextListItem[])**

Creates an ordered list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendOrderedList(IMarkdownDocument document, MarkdownTextListItem[] items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`items` [MarkdownTextListItem[]](./markdown.markdowntextlistitem)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendOrderedList(IMarkdownDocument, IEnumerable&lt;MarkdownTextListItem&gt;)**

Creates an ordered list with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendOrderedList(IMarkdownDocument document, IEnumerable<MarkdownTextListItem> items)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`items` [IEnumerable&lt;MarkdownTextListItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The list items.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendCode(IMarkdownDocument, String, String)**

Creates a code block with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendCode(IMarkdownDocument document, string language, string code)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`language` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code language.

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendCode(IMarkdownDocument, String, MarkdownInlineElement)**

Creates a code block with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendCode(IMarkdownDocument document, string language, MarkdownInlineElement code)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`language` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code language.

`code` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The code.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendBlockquote(IMarkdownDocument, String)**

Creates a blockquote with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendBlockquote(IMarkdownDocument document, string text)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The blockquote text.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendBlockquote(IMarkdownDocument, MarkdownInlineElement)**

Creates a blockquote with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendBlockquote(IMarkdownDocument document, MarkdownInlineElement text)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`text` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The blockquote text.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **AppendTable(IMarkdownDocument, MarkdownTableHeader, IEnumerable&lt;MarkdownTableRow&gt;)**

Creates a table with the specified arguments and appends this to the document.

```csharp
public static IMarkdownDocument AppendTable(IMarkdownDocument document, MarkdownTableHeader header, IEnumerable<MarkdownTableRow> rows)
```

#### Parameters

`document` [IMarkdownDocument](./markdown.imarkdowndocument)<br>
The current document.

`header` [MarkdownTableHeader](./markdown.markdowntableheader)<br>
The header.

`rows` [IEnumerable&lt;MarkdownTableRow&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The rows.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

---

[`< Back`](./)
