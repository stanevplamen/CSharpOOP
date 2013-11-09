using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class Audio : MultimediaDocument, IDocument
    {
        private string srate;
        public string SRate
        {
            get
            {
                return this.srate;
            }
            protected set
            {
                this.srate = value;
            }
        }

        public override void LoadProperty(string key, string value)
        {
            if (key == "samplerate")
            {
                this.SRate = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("samplerate", this.SRate));
        }
    }
}
