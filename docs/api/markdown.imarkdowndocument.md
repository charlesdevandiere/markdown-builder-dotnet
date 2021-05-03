[`< Back`](./)

---

# IMarkdownDocument

Namespace: Markdown

Markdown document.

```csharp
public interface IMarkdownDocument
```

## Properties

### **Capacity**

Gets or sets the maximum number of markdown block elements that can be contained in the memory allocated by the current instance.

```csharp
public abstract int Capacity { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of markdown block elements that can be contained in the memory allocated by the current instance.

### **Length**

Gets the length of the current [IMarkdownDocument](./markdown.imarkdowndocument) object.

```csharp
public abstract int Length { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The length of this instance.

## Methods

### **Clear()**

Clears this markdown document.

```csharp
IMarkdownDocument Clear()
```

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the clean operation has completed.

### **Append(IMarkdownBlockElement)**

Appends the specified block element.

```csharp
IMarkdownDocument Append(IMarkdownBlockElement blockElement)
```

#### Parameters

`blockElement` [IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
The block element.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the append operation has completed.

### **Remove(Int32)**

Removes the specified block element at index.

```csharp
IMarkdownDocument Remove(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The block element index.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the excise operation has completed.

### **Remove(IMarkdownBlockElement)**

Remove the specified block element.

```csharp
IMarkdownDocument Remove(IMarkdownBlockElement blockElement)
```

#### Parameters

`blockElement` [IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
The block element.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the excise operation has completed.

### **ElementAt(Int32)**

Returns the specified block element at index.

```csharp
IMarkdownBlockElement ElementAt(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The block element index.

#### Returns

[IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
The block element.

### **IndexOf(IMarkdownBlockElement)**

Returns the specified block element index.

```csharp
int IndexOf(IMarkdownBlockElement blockElement)
```

#### Parameters

`blockElement` [IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
The block element.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The block element index.

### **Replace(IMarkdownBlockElement, IMarkdownBlockElement)**

Replaces all occurrences of a specified block element in this instance with another specified block element.

```csharp
IMarkdownDocument Replace(IMarkdownBlockElement oldBlockElement, IMarkdownBlockElement newBlockElement)
```

#### Parameters

`oldBlockElement` [IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
The block element to replace.

`newBlockElement` [IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
The block element that replaces oldBlockElement.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance with all instances of oldBlockElement replaced by newBlockElement.

### **Insert(Int32, IMarkdownBlockElement)**

Inserts the specified block element into this instance at a specified position.

```csharp
IMarkdownDocument Insert(int index, IMarkdownBlockElement blockElement)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The position in this instance where insertion begins.

`blockElement` [IMarkdownBlockElement](./markdown.imarkdownblockelement)<br>
The block element to insert.

#### Returns

[IMarkdownDocument](./markdown.imarkdowndocument)<br>
A reference to this instance after the insert operation has completed.

### **ToString()**

Returns a string that represents the current markdown document.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A string that represents the current markdown document.

---

[`< Back`](./)
