using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownCheckListTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var checkList = new MarkdownCheckList();

            Assert.Empty(checkList.ListItems);
            Assert.Equal(string.Empty, checkList.ToString());
        }

        [Fact]
        public void TestConstructorWithListItems()
        {
            var checkList = new MarkdownCheckList(
                new MarkdownCheckListItem(true, "True"),
                new MarkdownCheckListItem(false, "False")
            );

            Assert.Equal(2, checkList.ListItems.Count);
        }

        [Fact]
        public void TestToString()
        {
            var checkList = new MarkdownCheckList(
                new MarkdownCheckListItem(true, "True"),
                new MarkdownCheckListItem(false, "False")
            );

            Assert.Equal("- [x] True" + Environment.NewLine + "- [ ] False" + Environment.NewLine, checkList.ToString());
        }
    }
}
