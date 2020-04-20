namespace Markdown
{
    /// <summary>
    /// Markdown image.
    /// </summary>
    public class MarkdownImage : MarkdownLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownImage" /> class.
        /// </summary>
        /// <param name="altText">The alternative text.</param>
        /// <param name="imageUrl">The image URL.</param>
        public MarkdownImage(string altText, string imageUrl) : base(altText, imageUrl) { }

        /// <summary>
        /// Returns a string that represents the current markdown image.
        /// </summary>
        /// <returns>A string that represents the current markdown image.</returns>
        public override string ToString()
        {
            return $"!{base.ToString()}";
        }
    }
}
