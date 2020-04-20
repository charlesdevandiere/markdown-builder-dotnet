using System;
using Dawn;

namespace Markdown
{
    /// <summary>
    /// Markdown header.
    /// </summary>
    public class MarkdownHeader : MarkdownTextElement, IMarkdownBlockElement
    {
        private int level;

        /// <summary>
        /// Gets or sets the header level.
        /// </summary>
        /// <value>The header level.</value>
        public int Level
        {
            get => this.level;
            set
            {
                Guard.Argument(value, nameof(value))
                    .GreaterThan(0)
                    .LessThan(7);
                this.level = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHeader" /> class.
        /// </summary>
        /// <param name="header">The header text.</param>
        /// <param name="level">The header level.</param>
        public MarkdownHeader(string header, int level) : base(header)
        {
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHeader" /> class.
        /// </summary>
        /// <param name="inlineElement">The header text as markdown inline element.</param>
        /// <param name="level">The header level.</param>
        public MarkdownHeader(MarkdownInlineElement inlineElement, int level) : base(inlineElement)
        {
            this.Level = level;
        }

        /// <summary>
        /// Returns a string that represents the current markdown header.
        /// </summary>
        /// <returns>A string that represents the current markdown header.</returns>
        public override string ToString()
        {
            return string.Concat(
                new string('#', this.Level),
                " ",
                this.Text.Trim(),
                Environment.NewLine);
        }
    }
}
