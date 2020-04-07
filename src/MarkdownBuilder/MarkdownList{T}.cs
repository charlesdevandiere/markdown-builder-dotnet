using System;
using System.Collections.Generic;
using System.Text;
using Dawn;

namespace Markdown
{
    /// <summary>
    /// Markdown list of T
    /// </summary>
    /// <typeparam name="T">The list items type.</typeparam>
    public abstract class MarkdownList<T> : IMarkdownListItem, IMarkdownBlockElement where T : IMarkdownListItem
    {
        private readonly char Char;

        /// <summary>
        /// Gets the list items.
        /// </summary>
        /// <value>List items.</value>
        public List<T> ListItems { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList{T}" /> class.
        /// </summary>
        public MarkdownList()
        {
            this.ListItems = new List<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList{T}" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        public MarkdownList(char @char) : this()
        {
            this.Char = @char;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList{T}" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(params T[] listItems)
        {
            this.ListItems = new List<T>(listItems);
            this.Char = '-';
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList{T}" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(IEnumerable<T> listItems)
        {
            this.ListItems = new List<T>(listItems);
            this.Char = '-';
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList{T}" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(char @char, params T[] listItems) : this(listItems)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList{T}" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(char @char, IEnumerable<T> listItems) : this(listItems)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Returns a string that represents the current markdown list.
        /// </summary>
        /// <returns>A string that represents the current markdown list.</returns>
        public override string ToString()
        {
            return string.Concat(this.Print(0));
        }

        /// <summary>
        /// Prints the bullet point.
        /// </summary>
        /// <param name="index">The index of the bullet point.</param>
        /// <returns>The string represent the bullet point.</returns>
        protected virtual string PrintBulletPoint(int index) => this.Char.ToString();

        private string Print(int level)
        {
            Guard.Argument(level, nameof(level))
                .GreaterThan(-1);

            var sb = new StringBuilder();
            for (int i = 0; i < this.ListItems.Count; i++)
            {
                switch (this.ListItems[i])
                {
                    case MarkdownTextListItem textListItem:
                        sb.Append(new string(' ', level * 2));
                        sb.Append(this.PrintBulletPoint(i));
                        sb.Append(" ");
                        sb.AppendLine(textListItem.ToString());
                        break;

                    case MarkdownTextList list:
                        sb.AppendLine(list.Print(level + 2));
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return sb.ToString();
        }
    }
}
