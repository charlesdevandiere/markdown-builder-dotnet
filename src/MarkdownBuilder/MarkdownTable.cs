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
    public class MarkdownTable : IMarkdownBlockElement
    {
        /// <summary>Gets the header.</summary>
        /// <value>The header.</value>
        public MarkdownTableHeader Header { get; }

        /// <summary>Gets the rows.</summary>
        /// <value>The rows.</value>
        private List<MarkdownTableRow> Rows { get; }

        public int ColumnCount => this.Header.Cells.Length;

        public int RowsCount => this.Rows.Count;

        public int RowsCapacity
        {
            get => this.Rows.Capacity;
            set
            {
                this.CheckRowsCapacity(value);
                this.Rows.Capacity = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        public MarkdownTable(MarkdownTableHeader header)
        {
            Guard.Argument(header, nameof(header))
                .NotNull();

            this.Header = header;
            this.Rows = new List<MarkdownTableRow>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="rows">The rows.</param>
        public MarkdownTable(MarkdownTableHeader header, IEnumerable<MarkdownTableRow> rows)
        {
            Guard.Argument(header, nameof(header))
                .NotNull();

            this.Header = header;

            foreach (MarkdownTableRow row in rows)
            {
                this.CheckRow(row);
            }

            this.Rows = new List<MarkdownTableRow>(rows);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <param name="capacity">The row capacity.</param>
        public MarkdownTable(MarkdownTableHeader header, int capacity) : this(header)
        {
            Guard.Argument(header, nameof(header))
                .NotNull();
            this.CheckRowsCapacity(capacity);

            this.Header = header;
            this.Rows = new List<MarkdownTableRow>(capacity);
        }

        public void AddRow(MarkdownTableRow row)
        {
            this.CheckRow(row);
            this.Rows.Add(row);
        }

        public void AddRowRange(IEnumerable<MarkdownTableRow> rows)
        {
            foreach (MarkdownTableRow row in rows)
            {
                this.CheckRow(row);
            }
            this.Rows.AddRange(rows);
        }

        public MarkdownTableRow GetRowAt(int index)
        {
            return this.Rows.ElementAt(index);
        }

        public void RemoveRowAt(int index)
        {
            this.Rows.RemoveAt(index);
        }

        private void CheckRowsCapacity(int capacity)
        {
            Guard.Argument(capacity, nameof(capacity))
                .GreaterThan(-1, (int value, int other) => $"Table rows capacity must be greater that or equal to 0.");
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

            foreach (MarkdownTableRow row in this.Rows)
            {
                sb.AppendLine(row.ToString());
            }

            return sb.ToString();
        }
    }
}
