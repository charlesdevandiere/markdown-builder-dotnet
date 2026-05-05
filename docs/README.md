# MarkdownBuilder

![logo](https://raw.githubusercontent.com/charlesdevandiere/markdown-builder-dotnet/master/logo.png)

Markdown builder for .NET Core.

[![Build Status](https://github.com/charlesdevandiere/markdown-builder-dotnet/actions/workflows/ci.yml/badge.svg)](https://github.com/charlesdevandiere/markdown-builder-dotnet/actions/workflows/ci.yml)
[![Nuget](https://img.shields.io/nuget/v/MarkdownBuilder.svg?color=blue&logo=nuget)](https://www.nuget.org/packages/MarkdownBuilder)
[![Downloads](https://img.shields.io/nuget/dt/MarkdownBuilder.svg?logo=nuget)](https://www.nuget.org/packages/MarkdownBuilder)

See sample [here](https://github.com/charlesdevandiere/markdown-builder-dotnet/tree/master/sample/MarkdownBuilder.Sample)

See API documentation [here](api)

## Install

```console
> dotnet add package MarkdownBuilder
```

## Usage

### Headers

```csharp
new MarkdownHeader("H1", 1);
// # H1
//
```

```csharp
new MarkdownHeader("H2", 2);
// ## H2
//
```

```csharp
new MarkdownHeader("H3", 3);
// ### H3
//
```

```csharp
new MarkdownHeader("H4", 4);
// #### H4
//
```

```csharp
new MarkdownHeader("H5", 5);
// ##### H5
//
```

```csharp
new MarkdownHeader("H6", 6);
// ###### H6
//
```

### Paragraphs

```csharp
new MarkdownParagraph("Lorem ipsum ...");
// Lorem ipsum ...
//
```

### Emphasis

```csharp
new MarkdownEmphasis("emphasis");
// *emphasis*
```

```csharp
new MarkdownStrongEmphasis("strong emphasis");
// **strong emphasis**
```

```csharp
new MarkdownStrikethrough("strikethrough");
// ~~strikethrough~~
```

### Line Breaks

```csharp
new MarkdownText("Line 1").AppendLineBreak().Append("Line 2");
// Line 1<br>
// Line 2
```

### Lists

```csharp
new MarkdownList("First item", "Second item");
// - First item
// - Second item
//
```

```csharp
new MarkdownOrderedList("First item", "Second item");
// 1. First item
// 2. Second item
//
```

```csharp
new MarkdownList(
    new MarkdownCheckListItem(true, "Done"),
    new MarkdownCheckListItem(false, "To do")
);
// - [x] Done
// - [ ] To do
//
```

Nested lists:

```csharp
new MarkdownList(
    new MarkdownTextListItem("First item"),
    new MarkdownTextListItem("Second item"),
    new MarkdownList(
        new MarkdownTextListItem("Sub item 1"),
        new MarkdownTextListItem("Sub item 2")
    )
);
// - First item
// - Second item
//   - Sub item 1
//   - Sub item 2
//
```

### Links

```csharp
new MarkdownLink(
    "markdown-builder-dotnet",
    "https://github.com/charlesdevandiere/markdown-builder-dotnet");
// [markdown-builder-dotnet](https://github.com/charlesdevandiere/markdown-builder-dotnet)
```

### Images

```csharp
new MarkdownImage(
    "logo",
    "https://raw.githubusercontent.com/charlesdevandiere/markdown-query-builder/master/logo.png");
// ![logo](https://raw.githubusercontent.com/charlesdevandiere/markdown-query-builder/master/logo.png)
```

### Code blocks

```csharp
new MarkdownInlineCode("code");
// `code`
```

```csharp
new MarkdownCode("csharp", "Console.Write(\"Hello World!\");");
// ```csharp
// Console.Write("Hello World!");
// ```
//
```

### Tables

```csharp
new MarkdownTable(
    new MarkdownTableHeader(
        new MarkdownTableHeaderCell[]
        {
            new MarkdownTableHeaderCell("Name"),
            new MarkdownTableHeaderCell("Age", MarkdownTableTextAlignment.Right)
        }),
    new MarkdownTableRow[]
    {
        new MarkdownTableRow("John", "27"),
        new MarkdownTableRow("Xavier", "42")
    }
);
// | Name | Age |
// | --- | --: |
// | John | 27 |
// | Xavier | 42 |
//
```

Pretty-printed table with aligned columns:

```csharp
var table = new MarkdownTable(
    new MarkdownTableHeader(
        new MarkdownTableHeaderCell("Name"),
        new MarkdownTableHeaderCell("Age", MarkdownTableTextAlignment.Right)
    ),
    new MarkdownTableRow[]
    {
        new MarkdownTableRow("John", "27"),
        new MarkdownTableRow("Xavier", "42")
    }
);
table.ToPrettyString();
// | Name   | Age |
// | ------ | --: |
// | John   |  27 |
// | Xavier |  42 |
//
```

### Blockquotes

```csharp
new MarkdownBlockquote("Lorem ipsum ...");
// > Lorem ipsum ...
//
```

Nested blockquotes with block elements:

```csharp
new MarkdownBlockquote(
    new MarkdownParagraph("A paragraph"),
    new MarkdownList("Item 1", "Item 2"),
    new MarkdownBlockquote("Nested quote")
);
// > A paragraph
// >
// > - Item 1
// > - Item 2
// >
// > > Nested quote
//
```

### Horizontal Rules

```csharp
new MarkdownHorizontalRule();
// ---
//
```

### Emojis

```csharp
new MarkdownEmoji("thumbsup");
// :thumbsup:
```

### Create markdown document

```csharp
IMarkdownDocument document = new MarkdownDocument();

document.Append(new MarkdownHeader("Lorem ipsum", 1));
document.Append(
    new MarkdownParagraph(
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
    )
);

Console.Write(document);
// Output:
// # Lorem ipsum
//
// Lorem ipsum dolor sit amet, consectetur adipiscing elit.
```

Use `ToPrettyString()` to render the document with aligned table columns:

```csharp
Console.Write(document.ToPrettyString());
```
