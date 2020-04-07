namespace Markdown
{
    /// <summary>
    /// Markdown check list.
    /// </summary>
    public class MarkdownCheckList : MarkdownList<MarkdownCheckListItem>, IMarkdownBlockElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownCheckList" /> class.
        /// </summary>
        public MarkdownCheckList() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownCheckList" /> class.
        /// </summary>
        /// <param name="listItems">The check list items.</param>
        public MarkdownCheckList(params MarkdownCheckListItem[] listItems) : base(listItems) { }
    }
}
