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
    public abstract class MarkdownList<T> : MarkdownListItem where T : MarkdownListItem
    {
        /// <summary>
        /// Gets or sets the list items.
        /// </summary>
        /// <value>List items.</value>
        protected List<T> ListItems { get; set; }

        private readonly char Char = '-';

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        public MarkdownList()
        {
            this.ListItems = new List<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        public MarkdownList(char @char) : this()
        {
            this.Char = @char;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(params T[] listItems)
        {
            this.ListItems = new List<T>(listItems);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownList" /> class.
        /// </summary>
        /// <param name="char">The bullet point character.</param>
        /// <param name="listItems">The list items.</param>
        public MarkdownList(char @char, params T[] listItems) : this(listItems)
        {
            this.Char = @char;
        }

        /// <summary>
        /// Adds a item to the end of the <see cref="MarkdownList" />.
        /// </summary>
        /// <param name="listItem">The list item to be added to the end of the <see cref="MarkdownList" />.</param>
        public void Add(T listItem)
        {
            this.ListItems.Add(listItem);
        }

        /// <summary>
        /// Adds the items of the specified collection to the end of the <see cref="MarkdownList" />.
        /// </summary>
        /// <param name="listItems">The item collection to be added to the end of the <see cref="MarkdownList" />.</param>
        public void AddRange(IEnumerable<T> listItems)
        {
            this.ListItems.AddRange(listItems);
        }

        /// <summary>
        /// Returns a string that represents the current markdown list.
        /// </summary>
        /// <returns>A string that represents the current markdown list.</returns>
        public override string ToString()
        {
            return string.Concat(this.Print(0), Environment.NewLine);
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
                .GreaterThan(0);

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

                    case MarkdownList list:
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
