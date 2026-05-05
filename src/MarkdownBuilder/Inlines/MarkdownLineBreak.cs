namespace Markdown;

/// <summary>
/// Markdown line break.
/// </summary>
public class MarkdownLineBreak : MarkdownInlineElement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownLineBreak" /> class.
    /// </summary>
    public MarkdownLineBreak() : base(string.Empty) { }

    /// <summary>
    /// Returns a string that represents the current markdown line break.
    /// </summary>
    /// <returns>A string that represents the current markdown line break.</returns>
    public override string ToString()
    {
        return $"<br>{Environment.NewLine}";
    }
}
