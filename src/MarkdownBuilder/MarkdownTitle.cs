using System;
using Dawn;

namespace Markdown
{
    /// <summary>
    /// Markdown title.
    /// </summary>
    public class MarkdownTitle : MarkdownTextElement
    {
        private int level;

        /// <summary>
        /// Gets or sets the title level.
        /// </summary>
        /// <value>The title level.</value>
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
        /// Initializes a new instance of the <see cref="MarkdownTitle" /> class.
        /// </summary>
        /// <param name="title">The title text.</param>
        /// <param name="level">The title level.</param>
        public MarkdownTitle(string title, int level) : base(title)
        {
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTitle" /> class.
        /// </summary>
        /// <param name="inlineElement">The title text as markdown inline element.</param>
        /// <param name="level">The title level.</param>
        public MarkdownTitle(MarkdownInlineElement inlineElement, int level) : base(inlineElement)
        {
            this.Level = level;
        }

        /// <summary>
        /// Returns a string that represents the current markdown title.
        /// </summary>
        /// <returns>A string that represents the current markdown title.</returns>
        public override string ToString()
        {
            return string.Concat(
                new string('#', this.Level),
                " ",
                this.Text.Trim(),
                Environment.NewLine,
                Environment.NewLine);
        }
    }
}
