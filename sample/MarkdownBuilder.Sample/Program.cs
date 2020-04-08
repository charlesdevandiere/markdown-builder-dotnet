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

            document.Append(new MarkdownTitle("Document", 1));

            document.Append(new MarkdownTitle("Paragraph", 2));
            document.Append(new MarkdownParagraph("Text"));

            document.Append(new MarkdownTitle("List", 2));
            document.Append(
                new MarkdownTextList(
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")));

            document.Append(new MarkdownTitle("Ordered list", 2));
            document.Append(
                new MarkdownOrderedList(
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")));

            document.Append(new MarkdownTitle("Check list", 2));
            document.Append(
                new MarkdownCheckList(
                    new MarkdownCheckListItem(true, "One"),
                    new MarkdownCheckListItem(false, "Two")));

            document.Append(new MarkdownTitle("Table", 2));
            document.Append(
                new MarkdownTable(
                    new MarkdownTableHeader(
                        new MarkdownTableHeaderCell[] { new MarkdownTableHeaderCell("Header"), new MarkdownTableHeaderCell("Header") }),
                    new MarkdownTableRow[] {
                        new MarkdownTableRow(new MarkdownText("cell"), new MarkdownText("cell")),
                        new MarkdownTableRow(new MarkdownText("cell"), new MarkdownText("cell"))
                    }));

            document.Append(new MarkdownTitle("Code", 2));
            document.Append(new MarkdownCode("csharp", "Console.Write(document);"));

            document.Append(new MarkdownTitle("Titles", 2));
            document.Append(new MarkdownTitle("Titles", 3));
            document.Append(new MarkdownTitle("Titles", 4));
            document.Append(new MarkdownTitle("Titles", 5));
            document.Append(new MarkdownTitle("Titles", 6));

            document.Append(new MarkdownTitle("Blockquote", 2));
            document.Append(new MarkdownBlockquote("Blockquote"));

            document.Append(new MarkdownTitle("HorizontalRule", 2));
            document.Append(new MarkdownHorizontalRule());

            document.Append(new MarkdownTitle("Image", 2));
            document.Append(new MarkdownParagraph(new MarkdownImage("GitHub", "https://github.githubassets.com/apple-touch-icon-180x180.png")));

            document.Append(new MarkdownTitle("Emoji", 2));
            document.Append(new MarkdownParagraph(new MarkdownEmoji("thumbsup")));

            document.Append(new MarkdownTitle("Emphasis", 2));
            document.Append(new MarkdownParagraph(new MarkdownEmphasis("Emphasis")));

            document.Append(new MarkdownTitle("StrongEmphasis", 2));
            document.Append(new MarkdownParagraph(new MarkdownStrongEmphasis("Strong emphasis")));

            document.Append(new MarkdownTitle("Strikethrough", 2));
            document.Append(new MarkdownParagraph(new MarkdownStrikethrough("Strikethrough")));

            document.Append(new MarkdownTitle("Inline code", 2));
            document.Append(new MarkdownParagraph(new MarkdownInlineCode("code")));

            document.Append(new MarkdownTitle("Link", 2));
            document.Append(new MarkdownParagraph(new MarkdownLink("markdown-builder-dotnet", "https://github.com/charlesdevandiere/markdown-builder-dotnet")));

            Console.Write(document);

            string path = Path.Combine(Directory.GetCurrentDirectory(), "document.md");
            using var outputFile = new StreamWriter(path);

            outputFile.Write(document);
        }
    }
}
