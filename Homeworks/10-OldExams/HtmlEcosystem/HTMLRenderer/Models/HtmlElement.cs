using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HtmlElement : IElement
    {
        private string name;
        private string textContent;
        private List<IElement> childElements = new List<IElement>();

        public HtmlElement(string name)
        {
            this.Name = name;
        }

        public HtmlElement(string name, string content)
        {
            this.Name = name;
            this.TextContent = content;
        }

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public virtual string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public void AddElement(IElement element)
        {
            if (element != null)
            {
                childElements.Add(element);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            this.Render(sb);
            return sb.ToString();
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append("<");
                output.Append(this.Name);
                output.Append(">");
            }
            if (this.TextContent != null)
            {
                output.Append(HTMLEncode(this.TextContent));
            }
            foreach (var childElement in this.childElements)
            {
                childElement.Render(output);
            }
            if (this.Name != null)
            {
                output.Append("</");
                output.Append(this.Name);
                output.Append(">");
            }
        }

        protected string HTMLEncode(string text)
        {
            StringBuilder result = new StringBuilder();
            foreach (var ch in text)
            {
                if (ch == '<')
                {
                    result.Append("&lt;");
                }
                else if (ch == '>')
                {
                    result.Append("&gt;");
                }
                else if (ch == '&')
                {
                    result.Append("&amp;");
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
    }
}
