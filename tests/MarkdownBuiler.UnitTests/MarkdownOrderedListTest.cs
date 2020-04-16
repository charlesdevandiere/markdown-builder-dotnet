using System;
using System.Collections.Generic;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownOrederedListTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var orderedList = new MarkdownOrderedList();

            Assert.Empty(orderedList.ListItems);
            Assert.Equal(string.Empty, orderedList.ToString());
        }

        [Fact]
        public void TestConstructorWithListItems()
        {
            var orderedList = new MarkdownOrderedList(
                new MarkdownTextListItem("One"),
                new MarkdownTextListItem("Two")
            );

            Assert.Equal(2, orderedList.ListItems.Count);
        }

        [Fact]
        public void TestConstructorWithListItemsEnumerable()
        {
            var orderedList = new MarkdownOrderedList(
                new List<MarkdownTextListItem>
                {
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")
                }
            );

            Assert.Equal(2, orderedList.ListItems.Count);
        }

        [Fact]
        public void TestConstructorWithStrings()
        {
            var orderedList = new MarkdownOrderedList(
                "One",
                "Two"
            );

            Assert.Equal(2, orderedList.ListItems.Count);
        }

        [Fact]
        public void TestToString()
        {
            var orderedList = new MarkdownOrderedList(
                new MarkdownTextListItem("One"),
                new MarkdownTextListItem("Two")
            );

            Assert.Equal(
                "1. One" + Environment.NewLine +
                "2. Two" + Environment.NewLine,
                orderedList.ToString()
            );
        }
    }
}
