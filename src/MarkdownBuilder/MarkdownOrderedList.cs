using System.Collections.Generic;

namespace Markdown
{
    /// <summary>
    /// Markdown ordered list.
    /// </summary>
    public class MarkdownOrderedList : MarkdownList, IMarkdownBlockElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownOrderedList" /> class.
        /// </summary>
        public MarkdownOrderedList() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownOrderedList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownOrderedList(params MarkdownTextListItem[] listItems) : base(listItems) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownOrderedList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownOrderedList(IEnumerable<MarkdownTextListItem> listItems) : base(listItems) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownOrderedList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownOrderedList(params string[] listItems) : base(listItems) { }

        /// <summary>
        /// Prints the bullet point.
        /// </summary>
        /// <param name="index">The index of the bullet point.</param>
        /// <returns>The string represent the bullet point.</returns>
        protected override string PrintBulletPoint(int index) => $"{index + 1}.";
    }
}
