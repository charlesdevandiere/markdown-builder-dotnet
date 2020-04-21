using System;
using Dawn;

namespace Markdown
{
    /// <summary>
    /// Markdown horizontal rule.
    /// </summary>
    public class MarkdownHorizontalRule : IMarkdownBlockElement
    {
        private char @char;

        /// <summary>
        /// Gets or sets the horizontal rule character.
        /// </summary>
        /// <value>Horizontal rule character.</value>
        public char Char
        {
            get => this.@char;
            set
            {
                Guard.Argument(value, nameof(value))
                    .In('-', '*', '_');
                this.@char = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHorizontalRule" /> class.
        /// </summary>
        public MarkdownHorizontalRule()
        {
            this.Char = '-';
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHorizontalRule" /> class.
        /// </summary>
        /// <param name="char">The horizontal rule character.</param>
        public MarkdownHorizontalRule(char @char)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Returns a string that represents the current markdown horizontal rule.
        /// </summary>
        /// <returns>A string that represents the current markdown horizontal rule.</returns>
        public override string ToString()
        {
            return string.Concat(this.Char, this.Char, this.Char, Environment.NewLine);
        }
    }
}
