using Dawn;

namespace Markdown
{
    /// <summary>
    /// Markdown text element.
    /// </summary>
    public abstract class MarkdownTextElement
    {
        /// <summary>
        /// Gets or sets the markdown inline element.
        /// </summary>
        /// <value>The markdown inline element.</value>
        protected MarkdownInlineElement InlineElement { get; set; }

        private string text;

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text or a string that represents the markdown inline element.</value>
        public string Text
        {
            get
            {
                if (this.InlineElement != null)
                {
                    this.text = this.InlineElement.ToString();
                }

                return this.text;
            }
            protected set => this.text = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextElement" /> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public MarkdownTextElement(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTextElement" /> class.
        /// </summary>
        /// <param name="inlineElement">The text as markdown inline element.</param>
        public MarkdownTextElement(MarkdownInlineElement inlineElement)
        {
            Guard.Argument(inlineElement, nameof(inlineElement)).NotNull();

            this.InlineElement = inlineElement;
        }
    }
}
