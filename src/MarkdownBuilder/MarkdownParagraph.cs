using System;

namespace Markdown
{
    /// <summary>
    /// Markdown paragraph.
    /// </summary>
    public class MarkdownParagraph : MarkdownTextElement, IMarkdownBlockElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownParagraph" /> class.
        /// </summary>
        /// <param name="text">The paragraph text.</param>
        public MarkdownParagraph(string text) : base(text) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownParagraph" /> class.
        /// </summary>
        /// <param name="inlineElement">The paragraph text as markdown inline element.</param>
        public MarkdownParagraph(MarkdownInlineElement inlineElement) : base(inlineElement) { }

        /// <summary>
        /// Returns a string that represents the current markdown paragraph.
        /// The paragraph text is trimed.
        /// </summary>
        /// <returns>A string that represents the current markdown paragraph.</returns>
        public override string ToString()
        {
            return string.Concat(this.Text.Trim(), Environment.NewLine);
        }
    }
}
