namespace Markdown;

/// <summary>
/// Markdown table row.
/// </summary>
public class MarkdownTableRow
{
    /// <summary>Gets the cells.</summary>
    /// <value>The cells.</value>
    public MarkdownInlineElement[] Cells { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTableRow"/> class.
    /// </summary>
    /// <param name="cells">The cells.</param>
    public MarkdownTableRow(IEnumerable<MarkdownInlineElement> cells)
    {
        ArgumentValidator.ThrowIfNull(cells, nameof(cells));

        this.Cells = cells.ToArray();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTableRow"/> class.
    /// </summary>
    /// <param name="cells">The cells.</param>
    public MarkdownTableRow(params MarkdownInlineElement[] cells)
    {
        ArgumentValidator.ThrowIfNull(cells, nameof(cells));

        this.Cells = (MarkdownInlineElement[])cells.Clone();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTableRow"/> class.
    /// </summary>
    /// <param name="cells">The cells.</param>
    public MarkdownTableRow(IEnumerable<string> cells)
    {
        ArgumentValidator.ThrowIfNull(cells, nameof(cells));

        this.Cells = cells.Select(cell => new MarkdownText(cell)).ToArray();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTableRow"/> class.
    /// </summary>
    /// <param name="cells">The cells.</param>
    public MarkdownTableRow(params string[] cells)
    {
        ArgumentValidator.ThrowIfNull(cells, nameof(cells));

        this.Cells = cells.Select(cell => new MarkdownText(cell)).ToArray();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTableRow"/> class.
    /// </summary>
    /// <param name="capacity">The capacity.</param>
    public MarkdownTableRow(int capacity)
    {
        ArgumentValidator.ThrowIfNotPositive(capacity, nameof(capacity));

        this.Cells = Enumerable.Range(0, capacity).Select(_ => new MarkdownText(string.Empty)).ToArray();
    }

    /// <summary>
    /// Returns a string that represents the current markdown table row.
    /// </summary>
    /// <returns>A string that represents the current markdown table row.</returns>
    public override string ToString()
    {
        return $"{string.Concat(this.Cells.Select(c => $"| {c} "))}|";
    }
}
