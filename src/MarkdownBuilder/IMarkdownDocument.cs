namespace Markdown
{
    /// <summary>
    /// Markdown document.
    /// </summary>
    public interface IMarkdownDocument
    {
        int Capacity { get; set; }

        int Length { get; }

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

        IMarkdownDocument Remove(IMarkdownBlockElement blockElement);

        IMarkdownBlockElement ElementAt(int index);

        int IndexOf(IMarkdownBlockElement blockElement);

        IMarkdownDocument Replace(IMarkdownBlockElement oldBlockElement, IMarkdownBlockElement newBlockElement);

        IMarkdownDocument Insert(int index, IMarkdownBlockElement blockElement);

        /// <summary>
        /// Returns a string that represents the current markdown document.
        /// </summary>
        /// <returns>A string that represents the current markdown document.</returns>
        string ToString();
    }
}
