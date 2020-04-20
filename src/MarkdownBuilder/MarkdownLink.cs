namespace Markdown
{
    /// <summary>
    /// Markdown link.
    /// </summary>
    public class MarkdownLink : MarkdownInlineElement
    {
        /// <summary>
        /// Gets or sets the link URL.
        /// </summary>
        /// <value>Link URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLink" /> class.
        /// </summary>
        /// <param name="text">The link text.</param>
        /// <param name="url">The link URL.</param>
        public MarkdownLink(string text, string url) : base(text)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownLink" /> class.
        /// </summary>
        /// <param name="inlineElement">The link text as markdown inline element.</param>
        /// <param name="url">The link URL.</param>
        public MarkdownLink(MarkdownInlineElement inlineElement, string url) : base(inlineElement)
        {
            this.Url = url;
        }

        /// <summary>
        /// Returns a string that represents the current markdown link.
        /// </summary>
        /// <returns>A string that represents the current markdown link.</returns>
        public override string ToString()
        {
            return $"[{this.Text}]({this.Url})";
        }
    }
}
