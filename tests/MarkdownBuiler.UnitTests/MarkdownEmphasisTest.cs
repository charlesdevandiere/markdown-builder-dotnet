using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownEmphasisTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("Emphasis", new MarkdownEmphasis("Emphasis").Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            var inlineElement = new MarkdownText("Inline element");
            Assert.Equal("Inline element", new MarkdownEmphasis(inlineElement).Text);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("*Emphasis*", new MarkdownEmphasis("Emphasis").ToString());
        }
    }
}
