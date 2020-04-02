using System;

namespace Markdown
{
    /// <summary>
    /// Markdown horizontal rule.
    /// </summary>
    public class MarkdownHorizontalRule
    {
        /// <summary>
        /// Gets or sets the horizontal rule character.
        /// </summary>
        /// <value>Horizontal rule character.</value>
        public char Char { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownHorizontalRule" /> class.
        /// </summary>
        /// <param name="char">The emphasis character. Default is '-'.</param>
        public MarkdownHorizontalRule(char @char = '-')
        {
            this.Char = @char;
        }

        /// <summary>
        /// Returns a string that represents the current markdown horizontal rule.
        /// </summary>
        /// <returns>A string that represents the current markdown horizontal rule.</returns>
        public override string ToString()
        {
            return string.Concat(this.Char, this.Char, this.Char, Environment.NewLine, Environment.NewLine);
        }
    }
}
