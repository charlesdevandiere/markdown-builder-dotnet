namespace Markdown;

/// <summary>
/// Markdown table text alignment extensions.
/// </summary>
public static class MarkdownTableTextAlignmentExtensions
{
    /// <summary>Prints the specified text alignment.</summary>
    /// <param name="textAlignment">The text alignment.</param>
    /// <returns>A string that represents the current markdown table text alignment.</returns>
    public static string Print(this MarkdownTableTextAlignment textAlignment)
    {
        return textAlignment.Print(3);
    }

    /// <summary>Prints the specified text alignment padded to the given width.</summary>
    /// <param name="textAlignment">The text alignment.</param>
    /// <param name="width">The column width (minimum 3).</param>
    /// <returns>A padded string that represents the current markdown table text alignment.</returns>
    public static string Print(this MarkdownTableTextAlignment textAlignment, int width)
    {
        return textAlignment switch
        {
            MarkdownTableTextAlignment.Left => ":" + new string('-', width - 1),
            MarkdownTableTextAlignment.Center => ":" + new string('-', width - 2) + ":",
            MarkdownTableTextAlignment.Right => new string('-', width - 1) + ":",
            _ => new string('-', width)
        };
    }
}
