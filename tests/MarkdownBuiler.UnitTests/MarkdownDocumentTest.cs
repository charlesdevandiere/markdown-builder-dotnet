using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownDocumentTest
    {
        [Fact]
        public void TestClear()
        {
            var document = new MarkdownDocument();
            document.Append(new MarkdownParagraph(""));

            document.Clear();

            Assert.Equal(0, document.Length);
        }

        [Fact]
        public void TestAppend()
        {
            var document = new MarkdownDocument();
            var paragraph = new MarkdownParagraph("");
            document.Append(paragraph);

            Assert.Equal(1, document.Length);
            Assert.Equal(paragraph, document.ElementAt(0));
        }

        [Fact]
        public void TestRemoveIndex()
        {
            var document = new MarkdownDocument();
            document.Append(new MarkdownParagraph(""));

            document.Remove(0);

            Assert.Equal(0, document.Length);
        }

        [Fact]
        public void TestRemoveElement()
        {
            var document = new MarkdownDocument();
            var paragraph = new MarkdownParagraph("");
            document.Append(paragraph);

            document.Remove(paragraph);

            Assert.Equal(0, document.Length);
        }

        [Fact]
        public void TestElementAt()
        {
            var document = new MarkdownDocument();
            var paragraph = new MarkdownParagraph("");
            document.Append(paragraph);

            Assert.Equal(paragraph, document.ElementAt(0));
        }

        [Fact]
        public void TestIndexOf()
        {
            var document = new MarkdownDocument();
            var paragraph = new MarkdownParagraph("");
            document.Append(paragraph);

            Assert.Equal(0, document.IndexOf(paragraph));
        }

        [Fact]
        public void TestReplace()
        {
            var document = new MarkdownDocument();
            var paragraph = new MarkdownParagraph("");
            document.Append(paragraph);

            var code = new MarkdownCode("text", "");
            document.Replace(paragraph, code);

            Assert.Equal(code, document.ElementAt(0));
        }

        [Fact]
        public void TestInsert()
        {
            var document = new MarkdownDocument();
            var paragraph = new MarkdownParagraph("");
            document.Append(paragraph);

            var code = new MarkdownCode("text", "");
            document.Insert(0, code);

            Assert.Equal(code, document.ElementAt(0));
            Assert.Equal(paragraph, document.ElementAt(1));
        }

        [Fact]
        public void TestToString()
        {
            var document = new MarkdownDocument();
            document.Append(new MarkdownTitle("Title", 1));
            document.Append(new MarkdownParagraph("Paragraph"));

            Assert.Equal("# Title" + Environment.NewLine + Environment.NewLine + "Paragraph" + Environment.NewLine, document.ToString());
        }
    }
}
