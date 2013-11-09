using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class TextDocument : Document, IEditable, IDocument
    {
        private string charset;
        public string Charset 
        { 
            get
            {
                return this.charset;
            }
            protected set
            {
                this.charset = value;
            }
        }

        public TextDocument(string name, string content, string charset) 
            : base(name, content)
        {
            this.Charset = charset;
        }

        public TextDocument()
        {
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
        }
    }
}
