using System.Text;

namespace Markdown;

/// <summary>
/// Markdown blockquote. Can contain any block elements (paragraphs, lists, code blocks, other blockquotes).
/// </summary>
public class MarkdownBlockquote : IMarkdownBlockElement
{
    /// <summary>
    /// Gets the block elements contained in the blockquote.
    /// </summary>
    /// <value>The block elements.</value>
    public List<IMarkdownBlockElement> BlockElements { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownBlockquote" /> class.
    /// </summary>
    /// <param name="elements">The block elements.</param>
    public MarkdownBlockquote(params IMarkdownBlockElement[] elements)
    {
        this.BlockElements = [.. elements];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownBlockquote" /> class.
    /// </summary>
    /// <param name="elements">The block elements.</param>
    public MarkdownBlockquote(IEnumerable<IMarkdownBlockElement> elements)
    {
        this.BlockElements = [.. elements];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownBlockquote" /> class with a text paragraph.
    /// </summary>
    /// <param name="text">The blockquote text.</param>
    public MarkdownBlockquote(string text) : this(new MarkdownParagraph(text)) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownBlockquote" /> class with an inline element paragraph.
    /// </summary>
    /// <param name="inlineElement">The blockquote text as markdown inline element.</param>
    public MarkdownBlockquote(MarkdownInlineElement inlineElement) : this(new MarkdownParagraph(inlineElement)) { }

    /// <summary>
    /// Returns a string that represents the current markdown blockquote.
    /// Each line of the contained block elements is prefixed with "&gt; ".
    /// </summary>
    /// <returns>A string that represents the current markdown blockquote.</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < this.BlockElements.Count; i++)
        {
            if (i > 0)
            {
                sb.AppendLine(">");
            }

            string content = this.BlockElements[i].ToString();
            string[] lines = content.Split([Environment.NewLine], StringSplitOptions.None);

            // Block elements typically end with NewLine, producing a trailing empty string
            int lineCount = lines.Length > 0 && string.IsNullOrEmpty(lines[lines.Length - 1])
                ? lines.Length - 1
                : lines.Length;

            for (int j = 0; j < lineCount; j++)
            {
                if (string.IsNullOrEmpty(lines[j]))
                {
                    sb.AppendLine(">");
                }
                else
                {
                    sb.Append("> ");
                    sb.AppendLine(lines[j]);
                }
            }
        }

        return sb.ToString();
    }
}
