using System.Text;

namespace Markdown;

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

    /// <summary>
    /// Gets the number of columns.
    /// </summary>
    public int ColumnCount => this.Header.Cells.Length;

    /// <summary>
    /// Gets the number of rows.
    /// </summary>
    public int RowsCount => this.Rows.Count;

    /// <summary>
    /// Gets or sets the rows capacity.
    /// </summary>
    /// <value>The rows capacity.</value>
    public int RowsCapacity
    {
        get => this.Rows.Capacity;
        set
        {
            CheckRowsCapacity(value);
            this.Rows.Capacity = value;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
    /// </summary>
    /// <param name="header">The header.</param>
    public MarkdownTable(MarkdownTableHeader header)
    {
        ArgumentValidator.ThrowIfNull(header, nameof(header));

        this.Header = header;
        this.Rows = [];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
    /// </summary>
    /// <param name="header">The header.</param>
    /// <param name="rows">The rows.</param>
    public MarkdownTable(MarkdownTableHeader header, IEnumerable<MarkdownTableRow> rows)
    {
        ArgumentValidator.ThrowIfNull(header, nameof(header));

        this.Header = header;

        foreach (MarkdownTableRow row in rows)
        {
            this.CheckRow(row);
        }

        this.Rows = [.. rows];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTable"/> class.
    /// </summary>
    /// <param name="header">The header.</param>
    /// <param name="capacity">The row capacity.</param>
    public MarkdownTable(MarkdownTableHeader header, int capacity) : this(header)
    {
        CheckRowsCapacity(capacity);

        this.Rows = new List<MarkdownTableRow>(capacity);
    }

    /// <summary>
    /// Adds the specific row at the end of the table.
    /// </summary>
    /// <param name="row">The row to be added.</param>
    public void AddRow(MarkdownTableRow row)
    {
        this.CheckRow(row);
        this.Rows.Add(row);
    }

    /// <summary>
    /// Adds the specific rows at the end of the table.
    /// </summary>
    /// <param name="rows">The rows to be added.</param>
    public void AddRowRange(IEnumerable<MarkdownTableRow> rows)
    {
        foreach (MarkdownTableRow row in rows)
        {
            this.CheckRow(row);
        }
        this.Rows.AddRange(rows);
    }

    /// <summary>
    /// Gets the row at the specific index.
    /// </summary>
    /// <param name="index">The row index.</param>
    /// <returns>The row</returns>
    public MarkdownTableRow GetRowAt(int index)
    {
        return this.Rows[index];
    }

    /// <summary>
    /// Remove the row at the specific index.
    /// </summary>
    /// <param name="index">The row index.</param>
    public void RemoveRowAt(int index)
    {
        this.Rows.RemoveAt(index);
    }

    private static void CheckRowsCapacity(int capacity)
    {
        ArgumentValidator.ThrowIfLessThan(capacity, 0, nameof(capacity), "Table rows capacity must be greater that or equal to 0.");
    }

    private void CheckRow(MarkdownTableRow row)
    {
        ArgumentValidator.ThrowIfNull(row, nameof(row));

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
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(this.Header.ToString());

        foreach (MarkdownTableRow row in this.Rows)
        {
            sb.AppendLine(row.ToString());
        }

        return sb.ToString();
    }

    /// <summary>
    /// Returns a pretty-printed string with aligned columns.
    /// Each column is padded to the width of its widest cell.
    /// </summary>
    /// <returns>A pretty-printed string that represents the current markdown table.</returns>
    public string ToPrettyString()
    {
        // Cache trimmed cell values to avoid redundant Trim() calls
        string[] headerTexts = new string[this.ColumnCount];
        int[] columnWidths = new int[this.ColumnCount];

        for (int c = 0; c < this.ColumnCount; c++)
        {
            headerTexts[c] = this.Header.Cells[c].Text.Trim();
            // Minimum width of 3 to fit alignment markers (:--,:-:,--:)
            columnWidths[c] = Math.Max(headerTexts[c].Length, 3);
        }

        string[][] rowTexts = new string[this.Rows.Count][];
        for (int r = 0; r < this.Rows.Count; r++)
        {
            rowTexts[r] = new string[this.ColumnCount];
            for (int c = 0; c < this.ColumnCount; c++)
            {
                rowTexts[r][c] = this.Rows[r].Cells[c].ToString().Trim();
                if (rowTexts[r][c].Length > columnWidths[c])
                {
                    columnWidths[c] = rowTexts[r][c].Length;
                }
            }
        }

        StringBuilder sb = new StringBuilder();

        for (int c = 0; c < this.ColumnCount; c++)
        {
            sb.Append("| ");
            sb.Append(headerTexts[c].PadRight(columnWidths[c]));
            sb.Append(' ');
        }
        sb.AppendLine("|");

        for (int c = 0; c < this.ColumnCount; c++)
        {
            sb.Append("| ");
            sb.Append(this.Header.Cells[c].ColumnTextAlignment.Print(columnWidths[c]));
            sb.Append(' ');
        }
        sb.AppendLine("|");

        for (int r = 0; r < rowTexts.Length; r++)
        {
            for (int c = 0; c < this.ColumnCount; c++)
            {
                sb.Append("| ");
                sb.Append(rowTexts[r][c].PadRight(columnWidths[c]));
                sb.Append(' ');
            }
            sb.AppendLine("|");
        }

        return sb.ToString();
    }
}
