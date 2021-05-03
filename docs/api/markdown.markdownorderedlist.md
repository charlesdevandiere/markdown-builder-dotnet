[`< Back`](./)

---

# MarkdownOrderedList

Namespace: Markdown

Markdown ordered list.

```csharp
public class MarkdownOrderedList : MarkdownList, IMarkdownListItem, IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownList](./markdown.markdownlist) → [MarkdownOrderedList](./markdown.markdownorderedlist)<br>
Implements [IMarkdownListItem](./markdown.imarkdownlistitem), [IMarkdownBlockElement](./markdown.imarkdownblockelement)

## Properties

### **Char**

Gets or sets the bullet point character.

```csharp
public char Char { get; set; }
```

#### Property Value

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

### **ListItems**

Gets the list items.

```csharp
public List<IMarkdownListItem> ListItems { get; }
```

#### Property Value

[List&lt;IMarkdownListItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List items.

## Constructors

### **MarkdownOrderedList()**

Initializes a new instance of the [MarkdownOrderedList](./markdown.markdownorderedlist) class.

```csharp
public MarkdownOrderedList()
```

### **MarkdownOrderedList(MarkdownTextListItem[])**

Initializes a new instance of the [MarkdownOrderedList](./markdown.markdownorderedlist) class.

```csharp
public MarkdownOrderedList(MarkdownTextListItem[] listItems)
```

#### Parameters

`listItems` [MarkdownTextListItem[]](./markdown.markdowntextlistitem)<br>
The list items.

### **MarkdownOrderedList(IEnumerable&lt;MarkdownTextListItem&gt;)**

Initializes a new instance of the [MarkdownOrderedList](./markdown.markdownorderedlist) class.

```csharp
public MarkdownOrderedList(IEnumerable<MarkdownTextListItem> listItems)
```

#### Parameters

`listItems` [IEnumerable&lt;MarkdownTextListItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The list items.

### **MarkdownOrderedList(String[])**

Initializes a new instance of the [MarkdownOrderedList](./markdown.markdownorderedlist) class.

```csharp
public MarkdownOrderedList(String[] listItems)
```

#### Parameters

`listItems` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The list items.

## Methods

### **PrintBulletPoint(Int32)**

Prints the bullet point.

```csharp
protected string PrintBulletPoint(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index of the bullet point.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string represent the bullet point.

---

[`< Back`](./)
