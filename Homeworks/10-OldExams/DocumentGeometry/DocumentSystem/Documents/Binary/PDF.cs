using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class PDF : BinaryDocument, IDocument, IEncryptable
    {
        private int numberOfPages;
        public int NumberOfPages
        {
            get { return this.numberOfPages; }
            protected set { this.numberOfPages = value; }
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.NumberOfPages = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        }

        private bool isencrypted;
        public bool IsEncrypted
        {
            get { return this.isencrypted; }
            private set { this.isencrypted = value; }
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }
    }
}
