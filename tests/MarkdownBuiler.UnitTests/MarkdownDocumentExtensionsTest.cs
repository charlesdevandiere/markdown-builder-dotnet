using System;
using System.Collections.Generic;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownDocumentExtensionsTest
    {
        [Fact]
        public void TestAppendHeader()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendHeader("Header", 1);
            MarkdownHeader header = Assert.IsType<MarkdownHeader>(document.ElementAt(0));
            Assert.Equal("Header", header.Text);
        }

        [Fact]
        public void TestAppendHeaderWithInlineElement()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendHeader(new MarkdownText("Header"), 1);
            MarkdownHeader header = Assert.IsType<MarkdownHeader>(document.ElementAt(0));
            Assert.Equal("Header", header.Text);
        }

        [Fact]
        public void TestParagraph()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendParagraph("Text");
            MarkdownParagraph paragraph = Assert.IsType<MarkdownParagraph>(document.ElementAt(0));
            Assert.Equal("Text", paragraph.Text);
        }

        [Fact]
        public void TestParagraphWithInlineElement()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendParagraph(new MarkdownText("Text"));
            MarkdownParagraph paragraph = Assert.IsType<MarkdownParagraph>(document.ElementAt(0));
            Assert.Equal("Text", paragraph.Text);
        }

        [Fact]
        public void TestHorizontalRule()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendHorizontalRule();
            Assert.IsType<MarkdownHorizontalRule>(document.ElementAt(0));
        }

        [Fact]
        public void TestHorizontalRuleWithChar()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendHorizontalRule('_');
            MarkdownHorizontalRule horizontalRule = Assert.IsType<MarkdownHorizontalRule>(document.ElementAt(0));
            Assert.Equal('_', horizontalRule.Char);
        }

        [Fact]
        public void TestList()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendList("First", "Second");
            MarkdownList list = Assert.IsType<MarkdownList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestListWithListItem()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendList(new MarkdownTextListItem("First"), new MarkdownTextListItem("Second"));
            MarkdownList list = Assert.IsType<MarkdownList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestListWithListItemEnumerable()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendList(
                new List<MarkdownTextListItem>
                {
                    new MarkdownTextListItem("First"),
                    new MarkdownTextListItem("Second")
                }
            );
            MarkdownList list = Assert.IsType<MarkdownList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestListWhithChar()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendList('*', "First", "Second");
            MarkdownList list = Assert.IsType<MarkdownList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
            Assert.Equal('*', list.Char);
        }

        [Fact]
        public void TestListWithCharAndListItem()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendList('*', new MarkdownTextListItem("First"), new MarkdownTextListItem("Second"));
            MarkdownList list = Assert.IsType<MarkdownList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
            Assert.Equal('*', list.Char);
        }

        [Fact]
        public void TestListWithCharAndListItemEnumerable()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendList(
                '*',
                new List<MarkdownTextListItem>
                {
                    new MarkdownTextListItem("First"),
                    new MarkdownTextListItem("Second")
                }
            );
            MarkdownList list = Assert.IsType<MarkdownList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
            Assert.Equal('*', list.Char);
        }

        [Fact]
        public void TestOrderedList()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendOrderedList("First", "Second");
            MarkdownOrderedList list = Assert.IsType<MarkdownOrderedList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestOrderedListWithListItem()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendOrderedList(new MarkdownTextListItem("First"), new MarkdownTextListItem("Second"));
            MarkdownOrderedList list = Assert.IsType<MarkdownOrderedList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestOrderedListWithListItemEnumerable()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendOrderedList(
                new List<MarkdownTextListItem>
                {
                    new MarkdownTextListItem("First"),
                    new MarkdownTextListItem("Second")
                }
            );
            MarkdownOrderedList list = Assert.IsType<MarkdownOrderedList>(document.ElementAt(0));
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestCode()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendCode("csharp", "Console.WriteLine(\"Hello World!\")");
            MarkdownCode code = Assert.IsType<MarkdownCode>(document.ElementAt(0));
            Assert.Equal("Console.WriteLine(\"Hello World!\")", code.Text);
        }

        [Fact]
        public void TestCodeWithInlineElement()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendCode("csharp", new MarkdownText("Console.WriteLine(\"Hello World!\")"));
            MarkdownCode code = Assert.IsType<MarkdownCode>(document.ElementAt(0));
            Assert.Equal("Console.WriteLine(\"Hello World!\")", code.Text);
        }

        [Fact]
        public void TestBlockquote()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendBlockquote("Text");
            MarkdownBlockquote blockquote = Assert.IsType<MarkdownBlockquote>(document.ElementAt(0));
            Assert.Equal("Text", blockquote.Text);
        }

        [Fact]
        public void TestBlockquoteWithInlineElement()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendBlockquote(new MarkdownText("Text"));
            MarkdownBlockquote blockquote = Assert.IsType<MarkdownBlockquote>(document.ElementAt(0));
            Assert.Equal("Text", blockquote.Text);
        }

        [Fact]
        public void TestTable()
        {
            IMarkdownDocument document = new MarkdownDocument().AppendTable(
                new MarkdownTableHeader(
                    new MarkdownTableHeaderCell[]
                    {
                        new MarkdownTableHeaderCell("Header"),
                        new MarkdownTableHeaderCell("Header")
                    }
                ),
                new MarkdownTableRow[]
                {
                    new MarkdownTableRow("cell", "cell"),
                    new MarkdownTableRow("cell", "cell")
                });
            MarkdownTable table = Assert.IsType<MarkdownTable>(document.ElementAt(0));
            Assert.Equal(2, table.ColumnCount);
            Assert.Equal(2, table.RowsCount);
        }
    }
}
