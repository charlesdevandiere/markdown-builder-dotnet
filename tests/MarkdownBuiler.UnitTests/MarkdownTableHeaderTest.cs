using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownTableHeaderTest
    {
        [Fact]
        public void TestInitializeWithCells()
        {
            Assert.Single(new MarkdownTableHeader(new MarkdownTableHeaderCell("")).Cells);
        }

        [Fact]
        public void TestInitializeWithCapacity()
        {
            Assert.Equal(3, new MarkdownTableHeader(3).Cells.Length);
        }

        [Fact]
        public void TestEmptyCells()
        {
            Assert.Throws<ArgumentException>(() => new MarkdownTableHeader(new MarkdownTableHeaderCell[0]));
        }

        [Fact]
        public void TestEmptyCapacity()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownTableHeader(0));
        }

        [Fact]
        public void TestToString()
        {
            var header = new MarkdownTableHeader(
                new MarkdownTableHeaderCell[]
                {
                    new MarkdownTableHeaderCell("Header"),
                    new MarkdownTableHeaderCell("Header")
                }
            );
            Assert.Equal(
                "| Header | Header |" + Environment.NewLine +
                "| --- | --- |",
                header.ToString()
            );
        }
    }
}
