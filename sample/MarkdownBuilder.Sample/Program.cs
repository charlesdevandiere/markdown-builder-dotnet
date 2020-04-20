using System;
using System.IO;
using Markdown;

namespace MarkdownBuilder.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IMarkdownDocument document = new MarkdownDocument();

            document.Append(new MarkdownHeader("Document", 1));

            document.Append(new MarkdownHeader("Paragraph", 2));
            document.Append(new MarkdownParagraph("Text"));

            document.Append(new MarkdownHeader("List", 2));
            document.Append(
                new MarkdownList(
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two"),
                    new MarkdownList(
                        new MarkdownTextListItem("First"),
                        new MarkdownTextListItem("Second")
                    )
                ));

            document.Append(new MarkdownHeader("Ordered list", 2));
            document.Append(
                new MarkdownOrderedList(
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")
                ));

            document.Append(new MarkdownHeader("Check list", 2));
            document.Append(
                new MarkdownList(
                    new MarkdownCheckListItem(true, "Done"),
                    new MarkdownCheckListItem(false, "To do"),
                    new MarkdownList(
                        new MarkdownCheckListItem(true, "Done")
                    )
                ));

            document.Append(new MarkdownHeader("Table", 2));
            document.Append(
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
                ));

            document.Append(new MarkdownHeader("Code", 2));
            document.Append(new MarkdownCode("csharp", "Console.Write(\"Hello World!\");"));

            document.Append(new MarkdownHeader("Headers", 2));
            document.Append(new MarkdownHeader("H1", 1));
            document.Append(new MarkdownHeader("H2", 2));
            document.Append(new MarkdownHeader("H3", 3));
            document.Append(new MarkdownHeader("H4", 4));
            document.Append(new MarkdownHeader("H5", 5));
            document.Append(new MarkdownHeader("H6", 6));

            document.Append(new MarkdownHeader("Blockquote", 2));
            document.Append(new MarkdownBlockquote("Blockquote"));

            document.Append(new MarkdownHeader("HorizontalRule", 2));
            document.Append(new MarkdownHorizontalRule());

            document.Append(new MarkdownHeader("Image", 2));
            document.Append(new MarkdownParagraph(new MarkdownImage("GitHub", "https://github.githubassets.com/apple-touch-icon-180x180.png")));

            document.Append(new MarkdownHeader("Emoji", 2));
            document.Append(new MarkdownParagraph(new MarkdownEmoji("thumbsup")));

            document.Append(new MarkdownHeader("Emphasis", 2));
            document.Append(new MarkdownParagraph(new MarkdownEmphasis("Emphasis")));

            document.Append(new MarkdownHeader("StrongEmphasis", 2));
            document.Append(new MarkdownParagraph(new MarkdownStrongEmphasis("Strong emphasis")));

            document.Append(new MarkdownHeader("Strikethrough", 2));
            document.Append(new MarkdownParagraph(new MarkdownStrikethrough("Strikethrough")));

            document.Append(new MarkdownHeader("Inline code", 2));
            document.Append(new MarkdownParagraph(new MarkdownInlineCode("code")));

            document.Append(new MarkdownHeader("Link", 2));
            document.Append(new MarkdownParagraph(new MarkdownLink("markdown-builder-dotnet", "https://github.com/charlesdevandiere/markdown-builder-dotnet")));

            Console.Write(document);

            string path = Path.Combine(Directory.GetCurrentDirectory(), "document.md");
            using var outputFile = new StreamWriter(path);

            outputFile.Write(document);
        }
    }
}
