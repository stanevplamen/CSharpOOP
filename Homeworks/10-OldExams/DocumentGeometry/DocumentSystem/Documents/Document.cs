using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public abstract class Document : IDocument
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        private string content;
        public string Content
        {
            get { return this.content; }
            protected set { this.content = value; }
        }
   
        public Document(string name, string content)
        {
            this.Name = name;
            this.Content = content;
        }

        public Document()
        {
        }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
            else
            {
                throw new ArgumentException(String.Format("Key '{0}' not found", name));
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            List<KeyValuePair<string, object>> properties =
                new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(properties);
            properties.Sort((a, b) => a.Key.CompareTo(b.Key));
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append("[");
            bool first = true;
            foreach (var prop in properties)
            {
                if (prop.Value != null)
                {
                    if (!first)
                    {
                        result.Append(";");
                    }
                    result.AppendFormat("{0}={1}", prop.Key, prop.Value);
                    first = false;
                }
            }
            result.Append("]");
            return result.ToString();
        }
    }
}
