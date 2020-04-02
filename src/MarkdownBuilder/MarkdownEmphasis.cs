namespace Markdown
{
    /// <summary>
    /// Markdown emphasis.
    /// </summary>
    public class MarkdownEmphasis : MarkdownInlineElement
    {
        /// <summary>
        /// Gets or sets the emphasis character.
        /// </summary>
        /// <value>Emphasis character.</value>
        public char Char { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownEmphasis" /> class.
        /// </summary>
        /// <param name="text">The emphasis text.</param>
        /// <param name="char">The emphasis character. Default is '*'.</param>
        public MarkdownEmphasis(string text, char @char = '*') : base(text)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownEmphasis" /> class.
        /// </summary>
        /// <param name="inlineElement">The emphasis text as markdown inline element.</param>
        /// <param name="char">The emphasis character. Default is '*'.</param>
        public MarkdownEmphasis(MarkdownInlineElement inlineElement, char @char = '*') : base(inlineElement)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Returns a string that represents the current markdown emphasis.
        /// </summary>
        /// <returns>A string that represents the current markdown emphasis.</returns>
        public override string ToString()
        {
            return $"{this.Char}{this.Text}{this.Char}";
        }
    }
}
