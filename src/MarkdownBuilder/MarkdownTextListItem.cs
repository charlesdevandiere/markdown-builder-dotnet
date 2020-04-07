namespace Markdown
{
    /// <summary>
    /// Markdown text list item.
    /// </summary>
    public class MarkdownTextListItem : MarkdownTextElement, IMarkdownListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextListItem" /> class.
        /// </summary>
        /// <param name="text">The list item text.</param>
        public MarkdownTextListItem(string text) : base(text) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextListItem" /> class.
        /// </summary>
        /// <param name="inlineElement">The list item text as markdown inline element.</param>
        public MarkdownTextListItem(MarkdownInlineElement inlineElement) : base(inlineElement) { }

        /// <summary>
        /// Returns a string that represents the current markdown text list item.
        /// </summary>
        /// <returns>A string that represents the current markdown text list item.</returns>
        public override string ToString()
        {
            return this.Text.Trim();
        }
    }
}
