namespace Markdown
{
    /// <summary>
    /// Markdown strikethrough.
    /// </summary>
    public class MarkdownStrikethrough : MarkdownInlineElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrikethrough" /> class.
        /// </summary>
        /// <param name="text">The strikethrough text.</param>
        public MarkdownStrikethrough(string text) : base(text) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrikethrough" /> class.
        /// </summary>
        /// <param name="inlineElement">The strikethrough text as markdown inline element.</param>
        public MarkdownStrikethrough(MarkdownInlineElement inlineElement) : base(inlineElement) { }

        /// <summary>
        /// Returns a string that represents the current markdown strikethrough.
        /// </summary>
        /// <returns>A string that represents the current markdown strikethrough.</returns>
        public override string ToString()
        {
            return $"~~{this.Text}~~";
        }
    }
}
