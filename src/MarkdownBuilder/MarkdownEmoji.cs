namespace Markdown
{
    /// <summary>
    /// Markdown emoji.
    /// </summary>
    public class MarkdownEmoji : MarkdownInlineElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownEmoji" /> class.
        /// </summary>
        /// <param name="code">The emoji code.</param>
        public MarkdownEmoji(string code) : base(code) { }

        /// <summary>
        /// Returns a string that represents the current markdown emoji code.
        /// </summary>
        /// <returns>A string that represents the current markdown emoji code.</returns>
        public override string ToString()
        {
            return $":{this.Text}:";
        }
    }
}
