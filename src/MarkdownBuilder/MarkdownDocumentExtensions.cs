using System.Collections.Generic;

namespace Markdown
{
    /// <summary>
    /// Markdown document extensions.
    /// </summary>
    public static class MarkdownDocumentExtensions
    {
        /// <summary>
        /// Creates an header with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="header">The header text.</param>
        /// <param name="level">The header level.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendHeader(this IMarkdownDocument document, string header, int level)
        {
            return document.Append(new MarkdownHeader(header, level));
        }

        /// <summary>
        /// Creates an header with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="header">The header text.</param>
        /// <param name="level">The header level.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendHeader(this IMarkdownDocument document, MarkdownInlineElement header, int level)
        {
            return document.Append(new MarkdownHeader(header, level));
        }

        /// <summary>
        /// Creates a paragraph with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="text">The paragraph text.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendParagraph(this IMarkdownDocument document, string text)
        {
            return document.Append(new MarkdownParagraph(text));
        }

        /// <summary>
        /// Creates a paragraph with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="text">The paragraph text.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendParagraph(this IMarkdownDocument document, MarkdownInlineElement text)
        {
            return document.Append(new MarkdownParagraph(text));
        }

        /// <summary>
        /// Creates an horizontal rule and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendHorizontalRule(this IMarkdownDocument document)
        {
            return document.Append(new MarkdownHorizontalRule());
        }

        /// <summary>
        /// Creates an horizontal rule with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="char">The horizontal rule character.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendHorizontalRule(this IMarkdownDocument document, char @char)
        {
            return document.Append(new MarkdownHorizontalRule(@char));
        }

        /// <summary>
        /// Creates a list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendList(this IMarkdownDocument document, params string[] items)
        {
            return document.Append(new MarkdownList(items));
        }

        /// <summary>
        /// Creates a list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendList(this IMarkdownDocument document, params IMarkdownListItem[] items)
        {
            return document.Append(new MarkdownList(items));
        }

        /// <summary>
        /// Creates a list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendList(this IMarkdownDocument document, IEnumerable<IMarkdownListItem> items)
        {
            return document.Append(new MarkdownList(items));
        }

        /// <summary>
        /// Creates a list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="char">The bullet point character.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendList(this IMarkdownDocument document, char @char, params string[] items)
        {
            return document.Append(new MarkdownList(@char, items));
        }

        /// <summary>
        /// Creates a list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="char">The bullet point character.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendList(this IMarkdownDocument document, char @char, params IMarkdownListItem[] items)
        {
            return document.Append(new MarkdownList(@char, items));
        }

        /// <summary>
        /// Creates a list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="char">The bullet point character.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendList(this IMarkdownDocument document, char @char, IEnumerable<IMarkdownListItem> items)
        {
            return document.Append(new MarkdownList(@char, items));
        }

        /// <summary>
        /// Creates an ordered list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendOrderedList(this IMarkdownDocument document, params string[] items)
        {
            return document.Append(new MarkdownOrderedList(items));
        }

        /// <summary>
        /// Creates an ordered list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendOrderedList(this IMarkdownDocument document, params MarkdownTextListItem[] items)
        {
            return document.Append(new MarkdownOrderedList(items));
        }

        /// <summary>
        /// Creates an ordered list with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="items">The list items.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendOrderedList(this IMarkdownDocument document, IEnumerable<MarkdownTextListItem> items)
        {
            return document.Append(new MarkdownOrderedList(items));
        }

        /// <summary>
        /// Creates a code block with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="language">The code language.</param>
        /// <param name="code">The code.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendCode(this IMarkdownDocument document, string language, string code)
        {
            return document.Append(new MarkdownCode(language, code));
        }

        /// <summary>
        /// Creates a code block with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="language">The code language.</param>
        /// <param name="code">The code.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendCode(this IMarkdownDocument document, string language, MarkdownInlineElement code)
        {
            return document.Append(new MarkdownCode(language, code));
        }

        /// <summary>
        /// Creates a blockquote with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="text">The blockquote text.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendBlockquote(this IMarkdownDocument document, string text)
        {
            return document.Append(new MarkdownBlockquote(text));
        }

        /// <summary>
        /// Creates a blockquote with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="text">The blockquote text.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendBlockquote(this IMarkdownDocument document, MarkdownInlineElement text)
        {
            return document.Append(new MarkdownBlockquote(text));
        }

        /// <summary>
        /// Creates a table with the specified arguments and appends this to the document.
        /// </summary>
        /// <param name="document">The current document.</param>
        /// <param name="header">The header.</param>
        /// <param name="rows">The rows.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static IMarkdownDocument AppendTable(this IMarkdownDocument document, MarkdownTableHeader header, IEnumerable<MarkdownTableRow> rows)
        {
            return document.Append(new MarkdownTable(header, rows));
        }
    }
}
