namespace Markdown
{
    /// <summary>
    /// Markdown strong emphasis.
    /// </summary>
    public class MarkdownStrongEmphasis : MarkdownInlineElement
    {
        /// <summary>
        /// Gets or sets the strong emphasis character.
        /// </summary>
        /// <value>Strong emphasis character.</value>
        public char Char { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrongEmphasis" /> class.
        /// </summary>
        /// <param name="text">The strong emphasis text.</param>
        /// <param name="char">The strong emphasis character. Default is '*'.</param>
        public MarkdownStrongEmphasis(string text, char @char = '*') : base(text)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownStrongEmphasis" /> class.
        /// </summary>
        /// <param name="inlineElement">The strong emphasis text as markdown inline element.</param>
        /// <param name="char">The strong emphasis character. Default is '*'.</param>
        public MarkdownStrongEmphasis(MarkdownInlineElement inlineElement, char @char = '*') : base(inlineElement)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Returns a string that represents the current markdown strong emphasis.
        /// </summary>
        /// <returns>A string that represents the current markdown strong emphasis.</returns>
        public override string ToString()
        {
            return $"{this.Char}{this.Char}{this.Text}{this.Char}{this.Char}";
        }
    }
}
