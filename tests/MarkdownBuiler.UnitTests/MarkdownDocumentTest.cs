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
        public void TestRemove()
        {
            var document = new MarkdownDocument();
            document.Append(new MarkdownParagraph(""));

            document.Remove(0);

            Assert.Equal(0, document.Length);
        }
        
        [Fact]
        public void TestToString()
        {
            var document = new MarkdownDocument();
            document.Append(new MarkdownTitle("Title", 1));
            document.Append(new MarkdownParagraph("Paragraph"));

            Assert.Equal("#Title" + Environment.NewLine + Environment.NewLine + "Paragraph" + Environment.NewLine, document.ToString());
        }
    }
}
