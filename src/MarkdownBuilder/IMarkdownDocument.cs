namespace Markdown
{
    /// <summary>
    /// Markdown document.
    /// </summary>
    public interface IMarkdownDocument
    {   
        /// <summary>
        /// Gets or sets the maximum number of markdown block elements that can be contained in the memory allocated by the current instance.
        /// </summary>
        /// <value>The maximum number of markdown block elements that can be contained in the memory allocated by the current instance.</value>
        int Capacity { get; set; }

        /// <summary>
        /// Gets the length of the current <see cref="IMarkdownDocument" /> object.
        /// </summary>
        /// <value>The length of this instance.</value>
        int Length { get; }

        /// <summary>Clears this markdown document.</summary>
        /// <returns>A reference to this instance after the clean operation has completed.</returns>
        IMarkdownDocument Clear();

        /// <summary>Appends the specified block element.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        IMarkdownDocument Append(IMarkdownBlockElement blockElement);

        /// <summary>Removes the specified block element at index.</summary>
        /// <param name="index">The block element index.</param>
        /// <returns>A reference to this instance after the excise operation has completed.</returns>
        IMarkdownDocument Remove(int index);

        /// <summary>Remove the specified block element.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>A reference to this instance after the excise operation has completed.</returns>
        IMarkdownDocument Remove(IMarkdownBlockElement blockElement);

        /// <summary>Returns the specified block element at index.</summary>
        /// <param name="index">The block element index.</param>
        /// <returns>The block element.</returns>
        IMarkdownBlockElement ElementAt(int index);

        /// <summary>Returns the specified block element index.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>The block element index.</returns>
        int IndexOf(IMarkdownBlockElement blockElement);

        /// <summary>Replaces all occurrences of a specified block element in this instance with another specified block element.</summary>
        /// <param name="oldBlockElement">The block element to replace.</param>
        /// <param name="newBlockElement">The block element that replaces <c>oldBlockElement</c>.</param>
        /// <returns>A reference to this instance with all instances of <c>oldBlockElement</c> replaced by <c>newBlockElement</c>.</returns>
        IMarkdownDocument Replace(IMarkdownBlockElement oldBlockElement, IMarkdownBlockElement newBlockElement);

        /// <summary>Inserts the specified block element into this instance at a specified position.</summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="blockElement">The block element to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        IMarkdownDocument Insert(int index, IMarkdownBlockElement blockElement);

        /// <summary>
        /// Returns a string that represents the current markdown document.
        /// </summary>
        /// <returns>A string that represents the current markdown document.</returns>
        string ToString();
    }
}
