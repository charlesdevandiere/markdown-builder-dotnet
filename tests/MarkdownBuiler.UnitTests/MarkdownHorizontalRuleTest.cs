using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownHorizontalRuleTest
    {
        [Fact]
        public void TestDefaultChar()
        {
            Assert.Equal('-', new MarkdownHorizontalRule().Char);
        }

        [Fact]
        public void TestCustomChar()
        {
            Assert.Equal('-', new MarkdownHorizontalRule('-').Char);
            Assert.Equal('*', new MarkdownHorizontalRule('*').Char);
            Assert.Equal('_', new MarkdownHorizontalRule('_').Char);
        }

        [Fact]
        public void TestForbidenChar()
        {
            Assert.Throws<ArgumentException>(() => new MarkdownHorizontalRule('a'));
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("---" + Environment.NewLine, new MarkdownHorizontalRule().ToString());
            Assert.Equal("---" + Environment.NewLine, new MarkdownHorizontalRule('-').ToString());
            Assert.Equal("***" + Environment.NewLine, new MarkdownHorizontalRule('*').ToString());
            Assert.Equal("___" + Environment.NewLine, new MarkdownHorizontalRule('_').ToString());
        }
    }
}
