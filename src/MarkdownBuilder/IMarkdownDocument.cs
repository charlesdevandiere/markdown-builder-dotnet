namespace Markdown
{
    /// <summary>
    /// Markdown document.
    /// </summary>
    public interface IMarkdownDocument
    {
        IMarkdownDocument Clear();

        IMarkdownDocument Append(IMarkdownBlockElement blockElement);

        IMarkdownDocument Remove(int index);
        
        string ToString();
    }
}
