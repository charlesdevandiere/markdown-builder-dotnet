namespace Markdown;

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
        ArgumentValidator.ThrowIfEmpty(cells, nameof(cells), "Table header cells length must be greater that 0.");
        
        this.Cells = (MarkdownTableHeaderCell[])cells.Clone();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTableHeader"/> class.
    /// </summary>
    /// <param name="capacity">The header cell capacity.</param>
    public MarkdownTableHeader(int capacity)
    {
        ArgumentValidator.ThrowIfNotPositive(capacity, nameof(capacity), "Table header cells capacity must be greater that 0.");

        this.Cells = Enumerable.Range(0, capacity).Select(_ => new MarkdownTableHeaderCell(string.Empty)).ToArray();
    }

    /// <summary>
    /// Returns a string that represents the current markdown table header.
    /// </summary>
    /// <returns>A string that represents the current markdown table header.</returns>
    public override string ToString()
    {
        var headerTexts = new System.Text.StringBuilder();
        var columnAlignments = new System.Text.StringBuilder();

        foreach (MarkdownTableHeaderCell cell in this.Cells)
        {
            headerTexts.Append($"| {cell.Text} ");
            columnAlignments.Append($"| {cell.ColumnTextAlignment.Print()} ");
        }

        headerTexts.Append('|');
        columnAlignments.Append('|');

        return string.Concat(headerTexts, Environment.NewLine, columnAlignments);
    }
}
