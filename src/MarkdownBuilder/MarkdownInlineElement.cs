namespace Markdown
{
    /// <summary>
    /// Markdown inline element.
    /// </summary>
    public abstract class MarkdownInlineElement : MarkdownTextElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInlineElement" /> class.
        /// </summary>
        /// <param name="text">The inline element text.</param>
        public MarkdownInlineElement(string text) : base(text) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownInlineElement" /> class.
        /// </summary>
        /// <param name="element">The inline element text as markdown inline element.</param>
        public MarkdownInlineElement(MarkdownInlineElement element) : base(element) { }
    }
}
