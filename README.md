# MarkdownBuilder

![logo](https://raw.githubusercontent.com/charlesdevandiere/markdown-builder-dotnet/master/logo.png)

Markdown builder for .NET Core.

[![Build Status](https://dev.azure.com/charlesdevandiere/charlesdevandiere/_apis/build/status/charlesdevandiere.markdown-builder-dotnet?branchName=master)](https://dev.azure.com/charlesdevandiere/charlesdevandiere/_build/latest?definitionId=4&branchName=master)
![Coverage](https://img.shields.io/azure-devops/coverage/charlesdevandiere/charlesdevandiere/4/master)
[![Nuget](https://img.shields.io/nuget/v/MarkdownBuilder.svg?color=blue&logo=nuget)](https://www.nuget.org/packages/MarkdownBuilder)
[![Downloads](https://img.shields.io/nuget/dt/MarkdownBuilder.svg?logo=nuget)](https://www.nuget.org/packages/MarkdownBuilder)

See complete documentation [here](https://charlesdevandiere.github.io/markdown-builder-dotnet/)

See sample [here](sample/MarkdownBuilder.Sample)

## Install

```console
> dotnet add package MarkdownBuilder
```

## Usage

```csharp
IMarkdownDocument document = new MarkdownDocument();

document.Append(new MarkdownTitle("Lorem ipsum", 1));
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

## Dependencies

- [Dawn.Guard](https://www.nuget.org/packages/Dawn.Guard/) (>= 1.11.0)
