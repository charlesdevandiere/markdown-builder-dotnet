using System.Collections.Generic;
using System.Linq;

namespace Markdown
{
    /// <summary>
    /// Markdown text.
    /// </summary>
    public class MarkdownText : MarkdownInlineElement
    {
        private readonly ICollection<object> fragments = new List<object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownText" /> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public MarkdownText(string text) : base(text)
        {
            this.fragments.Add(text);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownText" /> class.
        /// </summary>
        /// <param name="inlineElement">The text as markdown inline element.</param>
        public MarkdownText(MarkdownInlineElement inlineElement) : base(inlineElement)
        {
            this.fragments.Add(inlineElement);
        }

        /// <summary>
        /// Appends the specified text to this instance.
        /// </summary>
        /// <param name="text">The text to append.</param>
        /// <returns>The markdown text.</returns>
        public MarkdownText Append(string text)
        {
            this.fragments.Add(text);

            return this;
        }

        /// <summary>
        /// Appends the specified markdown inline element to this instance.
        /// </summary>
        /// <param name="inlineElement">The markdown inline element to append.</param>
        /// <returns>The markdown text.</returns>
        public MarkdownText Append(MarkdownInlineElement inlineElement)
        {
            this.fragments.Add(inlineElement);

            return this;
        }

        /// <summary>
        /// Returns a string that represents the current markdown text.
        /// </summary>
        /// <returns>A string that represents the current markdown text.</returns>
        public override string ToString()
        {
            return string.Concat(this.fragments.Select(fragment => fragment.ToString()));
        }
    }
}
