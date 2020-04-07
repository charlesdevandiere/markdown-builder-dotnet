using System;

namespace Markdown
{
    /// <summary>
    /// Markdown blockqute.
    /// </summary>
    public class MarkdownBlockquote : MarkdownTextElement, IMarkdownBlockElement
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MarkdownBlockquote" /> class.
        /// </summary>
        /// <param name="text">The blockquote text.</param>
        public MarkdownBlockquote(string text) : base(text) { }

        /// <summary>
        /// Initializes a new instance of <see cref="MarkdownBlockquote" /> class.
        /// </summary>
        /// <param name="inlineElement">The blockquote text as markdown inline element.</param>
        public MarkdownBlockquote(MarkdownInlineElement inlineElement) : base(inlineElement) { }

        /// <summary>
        /// Returns a string that represents the current markdown blockquote.
        /// The blockquote text is trimed.
        /// </summary>
        /// <returns>A string that represents the current markdown blockquote.</returns>
        public override string ToString()
        {
            return string.Concat("> ", this.Text.Trim(), Environment.NewLine);
        }
    }
}
