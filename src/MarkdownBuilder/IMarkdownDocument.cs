namespace Markdown
{
    /// <summary>
    /// Markdown document.
    /// </summary>
    public interface IMarkdownDocument
    {
        /// <summary>Clears this markdown document.</summary>
        /// <returns>The markdown document.</returns>
        IMarkdownDocument Clear();

        /// <summary>Appends the specified block element.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>The markdown document.</returns>
        IMarkdownDocument Append(IMarkdownBlockElement blockElement);

        /// <summary>Removes the specified block element at index.</summary>
        /// <param name="index">The block element index.</param>
        /// <returns>The markdown document.</returns>
        IMarkdownDocument Remove(int index);

        /// <summary>
        /// Returns a string that represents the current markdown document.
        /// </summary>
        /// <returns>A string that represents the current markdown document.</returns>
        string ToString();
    }
}
