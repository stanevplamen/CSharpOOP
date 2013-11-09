﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class OfficeDocument : BinaryDocument, IDocument
    {
        private string version;
        public string Version
        {
            get
            {
                return this.version;
            }
            protected set
            {
                this.version = value;
            }
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "version")
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("version", this.Version));
        }
    }
}
