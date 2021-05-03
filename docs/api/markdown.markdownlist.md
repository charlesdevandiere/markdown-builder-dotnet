[`< Back`](./)

---

# MarkdownList

Namespace: Markdown

Markdown list.

```csharp
public class MarkdownList : IMarkdownListItem, IMarkdownBlockElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MarkdownList](./markdown.markdownlist)<br>
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

### **MarkdownList()**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList()
```

### **MarkdownList(Char)**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList(char char)
```

#### Parameters

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

### **MarkdownList(IMarkdownListItem[])**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList(IMarkdownListItem[] listItems)
```

#### Parameters

`listItems` [IMarkdownListItem[]](./markdown.imarkdownlistitem)<br>
The list items.

### **MarkdownList(IEnumerable&lt;IMarkdownListItem&gt;)**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList(IEnumerable<IMarkdownListItem> listItems)
```

#### Parameters

`listItems` [IEnumerable&lt;IMarkdownListItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The list items.

### **MarkdownList(String[])**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList(String[] listItems)
```

#### Parameters

`listItems` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The list items.

### **MarkdownList(Char, IMarkdownListItem[])**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList(char char, IMarkdownListItem[] listItems)
```

#### Parameters

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

`listItems` [IMarkdownListItem[]](./markdown.imarkdownlistitem)<br>
The list items.

### **MarkdownList(Char, IEnumerable&lt;IMarkdownListItem&gt;)**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList(char char, IEnumerable<IMarkdownListItem> listItems)
```

#### Parameters

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

`listItems` [IEnumerable&lt;IMarkdownListItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
The list items.

### **MarkdownList(Char, String[])**

Initializes a new instance of the [MarkdownList](./markdown.markdownlist) class.

```csharp
public MarkdownList(char char, String[] listItems)
```

#### Parameters

`char` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The bullet point character.

`listItems` [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The list items.

## Methods

### **AddItem(String)**

Creates an item with the specified string value and adds this at the end of the items list.

```csharp
public void AddItem(string item)
```

#### Parameters

`item` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The item as string.

### **AddItem(MarkdownInlineElement)**

Creates an item with the specified markdown inline element and adds this at the end of the items list.

```csharp
public void AddItem(MarkdownInlineElement item)
```

#### Parameters

`item` [MarkdownInlineElement](./markdown.markdowninlineelement)<br>
The item as markdown inline element.

### **ToString()**

Returns a string that represents the current markdown list.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown list.

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
