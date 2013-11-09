using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class Excel : OfficeDocument, IDocument, IEncryptable
    {
        private long numberOfRows;
        public long NumberOfRows
        {
            get { return this.numberOfRows; }
            protected set { this.numberOfRows = value; }
        }

        private long numberOfCols;
        public long NumberOfCols
        {
            get { return this.numberOfCols; }
            protected set { this.numberOfCols = value; }
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.NumberOfRows = long.Parse(value);
            }
            if (key == "cols")
            {
                this.NumberOfCols = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
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
