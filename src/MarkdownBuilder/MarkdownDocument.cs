using System;
using System.Collections.Generic;

namespace Markdown
{
    /// <summary>
    /// Markdown document.
    /// </summary>
    /// <seealso cref="Markdown.IMarkdownDocument" />
    public class MarkdownDocument : IMarkdownDocument
    {
        private readonly List<IMarkdownBlockElement> blockElements = new List<IMarkdownBlockElement>();

        /// <summary>Appends the specified block element.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>The markdown document.</returns>
        public IMarkdownDocument Append(IMarkdownBlockElement blockElement)
        {
            this.blockElements.Add(blockElement);

            return this;
        }

        /// <summary>Clears this markdown document.</summary>
        /// <returns>The markdown document.</returns>
        public IMarkdownDocument Clear()
        {
            this.blockElements.Clear();

            return this;
        }

        /// <summary>Removes the specified block element at index.</summary>
        /// <param name="index">The block element index.</param>
        /// <returns>The markdown document.</returns>
        public IMarkdownDocument Remove(int index)
        {
            this.blockElements.RemoveAt(index);

            return this;
        }

        /// <summary>
        /// Returns a string that represents the current markdown document.
        /// </summary>
        /// <returns>A string that represents the current markdown document.</returns>
        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.blockElements);
        }
    }
}
