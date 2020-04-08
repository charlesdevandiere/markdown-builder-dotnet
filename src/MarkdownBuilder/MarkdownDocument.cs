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
        private readonly List<IMarkdownBlockElement> blockElements;

        public int Length => this.blockElements.Count;

        public int Capacity
        {
            get => this.blockElements.Capacity;
            set => this.blockElements.Capacity = value;
        }

        public MarkdownDocument()
        {
            this.blockElements = new List<IMarkdownBlockElement>();
        }

        public MarkdownDocument(int capacity)
        {
            this.blockElements = new List<IMarkdownBlockElement>(capacity);
        }

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

        public IMarkdownBlockElement ElementAt(int index) => this.blockElements[index];

        public IMarkdownDocument Insert(int index, IMarkdownBlockElement blockElement)
        {
            this.blockElements.Insert(index, blockElement);

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

        public IMarkdownDocument Remove(IMarkdownBlockElement blockElement)
        {
            this.blockElements.Remove(blockElement);

            return this;
        }

        public IMarkdownDocument Replace(IMarkdownBlockElement oldBlockElement, IMarkdownBlockElement newBlockElement)
        {
            this.blockElements
                .FindAll(element => element == oldBlockElement)
                .ForEach(element => element = newBlockElement);

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
