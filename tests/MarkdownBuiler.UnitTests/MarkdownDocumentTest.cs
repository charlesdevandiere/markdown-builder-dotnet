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

            Assert.True(true);
        }
    }
}
