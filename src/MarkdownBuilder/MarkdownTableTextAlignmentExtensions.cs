namespace Markdown
{
    /// <summary>
    /// Markdown table text alignment extensions.
    /// </summary>
    public static class MarkdownTableTextAlignmentExtensions
    {
        /// <summary>Prints the specified text alignment.</summary>
        /// <param name="textAlignment">The text alignment.</param>
        /// <returns>A string that represents the current markdown table text alignment.</returns>
        public static string Print(this MarkdownTableTextAlignment textAlignment)
        {
            return textAlignment switch
            {
                MarkdownTableTextAlignment.Left => ":--",
                MarkdownTableTextAlignment.Center => ":-:",
                MarkdownTableTextAlignment.Right => "--:",
                _ => "---"
            };
        }
    }
}
