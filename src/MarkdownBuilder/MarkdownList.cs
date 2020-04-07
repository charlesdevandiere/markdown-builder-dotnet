using System.Collections.Generic;

namespace Markdown
{
    /// <summary>
    /// Markdown list.
    /// </summary>
    public class MarkdownList : MarkdownList<MarkdownListItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        public MarkdownList() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        public MarkdownList(char @char) : base(@char) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(params MarkdownListItem[] listItems) : base(listItems) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(IEnumerable<MarkdownListItem> listItems) : base(listItems) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(char @char, IEnumerable<MarkdownListItem> listItems) : base(@char, listItems) { }
    }
}
