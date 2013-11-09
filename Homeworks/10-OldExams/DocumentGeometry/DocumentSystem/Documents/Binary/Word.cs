using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class Word : OfficeDocument, IEditable, IDocument, IEncryptable
    {
        private long numberOfChars;
        public long NumberOfChars
        {
            get { return this.numberOfChars; }
            protected set { this.numberOfChars = value; }
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.NumberOfChars = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfChars));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        private bool isencrypted;
        public bool IsEncrypted
        {
            get { return this.isencrypted ; }
            private set { this.isencrypted = value;  }
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                return this.GetType().Name + "[encrypted]";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
