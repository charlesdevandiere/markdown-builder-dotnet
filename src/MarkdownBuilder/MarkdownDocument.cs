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

        /// <summary>
        /// Gets or sets the maximum number of markdown block elements that can be contained in the memory allocated by the current instance.
        /// </summary>
        /// <value>The maximum number of markdown block elements that can be contained in the memory allocated by the current instance.</value>
        public int Capacity
        {
            get => this.blockElements.Capacity;
            set => this.blockElements.Capacity = value;
        }

        /// <summary>
        /// Gets the length of the current <see cref="IMarkdownDocument" /> object.
        /// </summary>
        /// <value>The length of this instance.</value>
        public int Length => this.blockElements.Count;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownDocument" /> class.
        /// </summary>
        public MarkdownDocument()
        {
            this.blockElements = new List<IMarkdownBlockElement>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownDocument" /> class.
        /// </summary>
        /// <param name="capacity">The block elements capacity.</param>
        public MarkdownDocument(int capacity)
        {
            this.blockElements = new List<IMarkdownBlockElement>(capacity);
        }

        /// <summary>Appends the specified block element.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public IMarkdownDocument Append(IMarkdownBlockElement blockElement)
        {
            this.blockElements.Add(blockElement);

            return this;
        }

        /// <summary>Clears this markdown document.</summary>
        /// <returns>A reference to this instance after the clean operation has completed.</returns>
        public IMarkdownDocument Clear()
        {
            this.blockElements.Clear();

            return this;
        }

        /// <summary>Returns the specified block element at index.</summary>
        /// <param name="index">The block element index.</param>
        /// <returns>The block element.</returns>
        public IMarkdownBlockElement ElementAt(int index) => this.blockElements[index];

        /// <summary>Returns the specified block element index.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>The block element index.</returns>
        public int IndexOf(IMarkdownBlockElement blockElement)
        {
            return this.blockElements.IndexOf(blockElement);
        }

        /// <summary>Inserts the specified block element into this instance at a specified position.</summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="blockElement">The block element to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        public IMarkdownDocument Insert(int index, IMarkdownBlockElement blockElement)
        {
            this.blockElements.Insert(index, blockElement);

            return this;
        }

        /// <summary>Removes the specified block element at index.</summary>
        /// <param name="index">The block element index.</param>
        /// <returns>A reference to this instance after the excise operation has completed.</returns>
        public IMarkdownDocument Remove(int index)
        {
            this.blockElements.RemoveAt(index);

            return this;
        }

        /// <summary>Remove the specified block element.</summary>
        /// <param name="blockElement">The block element.</param>
        /// <returns>A reference to this instance after the excise operation has completed.</returns>
        public IMarkdownDocument Remove(IMarkdownBlockElement blockElement)
        {
            this.blockElements.Remove(blockElement);

            return this;
        }

        /// <summary>Replaces all occurrences of a specified block element in this instance with another specified block element.</summary>
        /// <param name="oldBlockElement">The block element to replace.</param>
        /// <param name="newBlockElement">The block element that replaces <c>oldBlockElement</c>.</param>
        /// <returns>A reference to this instance with all instances of <c>oldBlockElement</c> replaced by <c>newBlockElement</c>.</returns>
        public IMarkdownDocument Replace(IMarkdownBlockElement oldBlockElement, IMarkdownBlockElement newBlockElement)
        {
            for (int i = 0; i < this.blockElements.Count; i++)
            {
                if (this.blockElements[i] == oldBlockElement)
                {
                    this.blockElements[i] = newBlockElement;
                }
            }

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
