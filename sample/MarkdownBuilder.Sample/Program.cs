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

            document.Append(new MarkdownTitle("Test", 1));
            document.Append(new MarkdownParagraph("Description"));

            document.Append(new MarkdownTitle("List", 2));
            document.Append(new MarkdownTextList(new MarkdownTextListItem("One"), new MarkdownTextListItem("Tow")));

            document.Append(new MarkdownTitle("Ordered List", 2));
            document.Append(new MarkdownOrderedList(new MarkdownTextListItem("One"), new MarkdownTextListItem("Tow")));

            document.Append(new MarkdownTitle("Ordered List", 2));
            document.Append(new MarkdownCheckList(new MarkdownCheckListItem(true, "One"), new MarkdownCheckListItem(false, "Tow")));

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

            Console.Write(document);

            string path = Path.Combine(Directory.GetCurrentDirectory(), "document.md");
            using var outputFile = new StreamWriter(path);

            outputFile.Write(document);
        }
    }
}
