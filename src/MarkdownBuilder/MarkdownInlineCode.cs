namespace Markdown
{
    /// <summary>
    /// Markdown inline code.
    /// </summary>
    public class MarkdownInlineCode : MarkdownInlineElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInlineCode" /> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public MarkdownInlineCode(string code) : base(code) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInlineCode" /> class.
        /// </summary>
        /// <param name="inlineElement">The code as markdown inline element.</param>
        public MarkdownInlineCode(MarkdownInlineElement inlineElement) : base(inlineElement) { }

        /// <summary>
        /// Returns a string that represents the current markdown code.
        /// </summary>
        /// <returns>A string that represents the current markdown code.</returns>
        public override string ToString()
        {
            return $"`{this.Text}`";
        }
    }
}
