using System.Collections.Generic;

namespace Markdown
{
    /// <summary>
    /// Markdown list.
    /// </summary>
    public class MarkdownTextList : MarkdownList<MarkdownTextListItem>, IMarkdownBlockElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextList" /> class.
        /// </summary>
        public MarkdownTextList() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextList" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        public MarkdownTextList(char @char) : base(@char) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownTextList(params MarkdownTextListItem[] listItems) : base(listItems) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownTextList(IEnumerable<MarkdownTextListItem> listItems) : base(listItems) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextList" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        /// <param name="listItems">The list items.</param>
        public MarkdownTextList(char @char, IEnumerable<MarkdownTextListItem> listItems) : base(@char, listItems) { }
    }
}
