using System;
using System.Collections.Generic;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownTextListTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var list = new MarkdownTextList();

            Assert.Empty(list.ListItems);
            Assert.Equal('-', list.Char);
            Assert.Equal(string.Empty, list.ToString());
        }

        [Fact]
        public void TestConstructorWithChar()
        {
            Assert.Equal('-', new MarkdownTextList('-').Char);
            Assert.Equal('*', new MarkdownTextList('*').Char);
        }

        [Fact]
        public void TestConstructorInvalidChar()
        {
            Assert.Throws<ArgumentException>(() => new MarkdownTextList('a'));
        }

        [Fact]
        public void TestConstructorWithListItemsArray()
        {
            var list = new MarkdownTextList(
                new MarkdownTextListItem("One"),
                new MarkdownTextListItem("Two")
            );

            Assert.Equal('-', list.Char);
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestConstructorWithListItemsEnumerable()
        {
            var list = new MarkdownTextList(
                new List<MarkdownTextListItem> {
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")
                }
            );

            Assert.Equal('-', list.Char);
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestConstructorWithStringArray()
        {
            var list = new MarkdownTextList("One", "Two");

            Assert.Equal('-', list.Char);
            Assert.Equal(2, list.ListItems.Count);
        }

        [Fact]
        public void TestConstructorWithCharAndListItemsArray()
        {
            {
                var list = new MarkdownTextList(
                    '-',
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")
                );

                Assert.Equal('-', list.Char);
                Assert.Equal(2, list.ListItems.Count);
            }
            {
                var list = new MarkdownTextList(
                    '*',
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")
                );

                Assert.Equal('*', list.Char);
                Assert.Equal(2, list.ListItems.Count);
            }
        }

        [Fact]
        public void TestConstructorInvalidCharAndListItemsArray()
        {
            Assert.Throws<ArgumentException>(
                () => new MarkdownTextList(
                    'a',
                    new MarkdownTextListItem("One"),
                    new MarkdownTextListItem("Two")
                )
            );
        }

        [Fact]
        public void TestConstructorWithCharAndListItemsEnumerable()
        {
            {
                var list = new MarkdownTextList(
                    '-',
                    new List<MarkdownTextListItem> {
                        new MarkdownTextListItem("One"),
                        new MarkdownTextListItem("Two")
                    }
                );

                Assert.Equal('-', list.Char);
                Assert.Equal(2, list.ListItems.Count);
            }
            {
                var list = new MarkdownTextList(
                    '*',
                    new List<MarkdownTextListItem> {
                        new MarkdownTextListItem("One"),
                        new MarkdownTextListItem("Two")
                    }
                );

                Assert.Equal('*', list.Char);
                Assert.Equal(2, list.ListItems.Count);
            }
        }

        [Fact]
        public void TestConstructorInvalidCharAndListItemsEnumerable()
        {
            Assert.Throws<ArgumentException>(
                () => new MarkdownTextList(
                    'a',
                    new List<MarkdownTextListItem> {
                        new MarkdownTextListItem("One"),
                        new MarkdownTextListItem("Two")
                    }
                )
            );
        }

        [Fact]
        public void TestConstructorWithCharAndStringArray()
        {
            {
                var list = new MarkdownTextList('-', "One", "Two");

                Assert.Equal('-', list.Char);
                Assert.Equal(2, list.ListItems.Count);
            }
            {
                var list = new MarkdownTextList('*', "One", "Two");

                Assert.Equal('*', list.Char);
                Assert.Equal(2, list.ListItems.Count);
            }
        }

        [Fact]
        public void TestConstructorInvalidCharAndStringArray()
        {
            Assert.Throws<ArgumentException>(() => new MarkdownTextList('a', "One", "Two"));
        }

        [Fact]
        public void TestToString()
        {
            var list = new MarkdownTextList(
                new MarkdownTextListItem("One"),
                new MarkdownTextListItem("Two")
            );

            Assert.Equal("- One" + Environment.NewLine + "- Two" + Environment.NewLine, list.ToString());
        }
    }
}
