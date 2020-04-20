namespace Markdown
{
    /// <summary>
    /// Markdown table header cell.
    /// </summary>
    public class MarkdownTableHeaderCell : MarkdownTextElement
    {
        /// <summary>
        /// Gets or sets the column text alignment.
        /// </summary>
        /// <value>The column text alignment.</value>
        public MarkdownTableTextAlignment ColumnTextAlignment { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableHeaderCell" /> class.
        /// </summary>
        /// <param name="text">The header cell text.</param>
        public MarkdownTableHeaderCell(string text) : base(text) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableHeaderCell" /> class.
        /// </summary>
        /// <param name="text">The header cell text.</param>
        /// <param name="textAlignment">The column text alignment.</param>
        public MarkdownTableHeaderCell(string text, MarkdownTableTextAlignment textAlignment) : base(text)
        {
            this.ColumnTextAlignment = textAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableHeaderCell" /> class.
        /// </summary>
        /// <param name="inlineElement">The header cell text as markdown inline element.</param>
        public MarkdownTableHeaderCell(MarkdownInlineElement inlineElement) : base(inlineElement) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableHeaderCell" /> class.
        /// </summary>
        /// <param name="inlineElement">The header cell text as markdown inline element.</param>
        /// <param name="textAlignment">The column text alignment.</param>
        public MarkdownTableHeaderCell(MarkdownInlineElement inlineElement, MarkdownTableTextAlignment textAlignment) : base(inlineElement)
        {
            this.ColumnTextAlignment = textAlignment;
        }
    }
}
