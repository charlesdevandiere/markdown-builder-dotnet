using System;
using System.Collections.Generic;

namespace Markdown
{
    public class MarkdownDocument : IMarkdownDocument
    {
        private readonly List<IMarkdownBlockElement> blockElements = new List<IMarkdownBlockElement>();

        public IMarkdownDocument Append(IMarkdownBlockElement blockElement)
        {
            this.blockElements.Add(blockElement);

            return this;
        }

        public IMarkdownDocument Clear()
        {
            this.blockElements.Clear();

            return this;
        }

        public IMarkdownDocument Remove(int index)
        {
            this.blockElements.RemoveAt(index);

            return this;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.blockElements);
        }
    }
}
