using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public abstract class BinaryDocument : Document, IDocument
    {
        private int? size;
        public int? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public BinaryDocument(string name, string content, int size) : base(name, content)
        {
            this.Size = size;
        }

        public BinaryDocument()
        {
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    this.Size = null;
                }
                else
                {
                    this.Size = int.Parse(value);
                }
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("size", this.Size));
        }
    }
}
