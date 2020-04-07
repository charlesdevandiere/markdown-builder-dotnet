using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dawn;

namespace Markdown
{
    /// <summary>
    /// Markdown table.
    /// </summary>
    public class MarkdownTable
    {
        /// <summary>Gets the header.</summary>
        /// <value>The header.</value>
        public MarkdownTableHeader Header { get; }

        /// <summary>Gets the rows.</summary>
        /// <value>The rows.</value>
        public ICollection<MarkdownTableRow> Rows { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        public MarkdownTable(MarkdownTableHeader header)
        {
            Guard.Argument(header, nameof(header))
                .NotNull()
                .Require(h => h.Cells.Length > 0);

            this.Header = header;
            this.Rows = new List<MarkdownTableRow>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="rows">The rows.</param>
        public MarkdownTable(MarkdownTableHeader header, ICollection<MarkdownTableRow> rows)
        {
            Guard.Argument(header, nameof(header))
                .NotNull()
                .Require(h => h.Cells.Length > 0);
            Guard.Argument(rows, nameof(rows))
                .NotNull();

            this.Header = header;

            foreach (MarkdownTableRow row in rows)
            {
                this.CheckRow(row);
            }

            this.Rows = rows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="capacity">The row capacity.</param>
        public MarkdownTable(MarkdownTableHeader header, int capacity) : this(header)
        {
            Guard.Argument(header, nameof(header))
                .NotNull()
                .Require(h => h.Cells.Length > 0);
            Guard.Argument(capacity, nameof(capacity))
                .GreaterThan(-1);

            this.Header = header;
            this.Rows = new List<MarkdownTableRow>(capacity);
        }

        private void CheckRow(MarkdownTableRow row)
        {
            Guard.Argument(row, nameof(row)).NotNull();

            if (row.Cells.Length != this.Header.Cells.Length)
            {
                throw new ArgumentException("Rows must have the same number of cells as headers.");
            }
        }

        /// <summary>
        /// Returns a string that represents the current markdown table.
        /// </summary>
        /// <returns>A string that represents the current markdown table.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.Header.ToString());

            foreach (MarkdownTableRow row in this.Rows.Where(r => r != null))
            {
                this.CheckRow(row);
                sb.AppendLine(row.ToString());
            }

            sb.AppendLine();

            return sb.ToString();
        }
    }
}
