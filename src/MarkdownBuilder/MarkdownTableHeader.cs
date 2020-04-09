using System;

namespace Markdown
{
    /// <summary>
    /// Markdown table header.
    /// </summary>
    public class MarkdownTableHeader
    {
        /// <summary>Gets the cells.</summary>
        /// <value>The cells.</value>
        public MarkdownTableHeaderCell[] Cells { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableHeader"/> class.
        /// </summary>
        /// <param name="cells">The cells.</param>
        public MarkdownTableHeader(params MarkdownTableHeaderCell[] cells)
        {
            this.Cells = (MarkdownTableHeaderCell[])cells.Clone();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTableHeader"/> class.
        /// </summary>
        /// <param name="capacity">The header cell capacity.</param>
        public MarkdownTableHeader(int capacity)
        {
            this.Cells = new MarkdownTableHeaderCell[capacity];
        }

        /// <summary>
        /// Returns a string that represents the current markdown table header.
        /// </summary>
        /// <returns>A string that represents the current markdown table header.</returns>
        public override string ToString()
        {
            string headerTexts = string.Empty;
            string columnAlignments = string.Empty;

            foreach (MarkdownTableHeaderCell cell in this.Cells)
            {
                headerTexts = string.Concat(headerTexts, $"| {cell.Text} ");
                columnAlignments = string.Concat(columnAlignments, $"| {cell.ColumnTextAlignment.Print()} ");
            }

            headerTexts = string.Concat(headerTexts, "|");
            columnAlignments = string.Concat(columnAlignments, "|");

            return string.Concat(headerTexts, Environment.NewLine, columnAlignments);
        }
    }
}
